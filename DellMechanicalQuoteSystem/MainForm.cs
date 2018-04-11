using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DellMechanicalQuoteSystem
{
    public partial class MainForm : Form
    {
        Quote quote;

        //holds the possition for controls to be placed on each tab
        int[] controlPossitions = new int[80];

        //holds the user controls that are dynamically added to the form
        SectionUserControl topUC;
        MaterialUserControl materialUC;

        public MainForm(string title)
        {
            InitializeComponent();

            quote = new Quote(title);

            //inittializes new usercontrols
            topUC = new SectionUserControl();
            materialUC = new MaterialUserControl();
            
            // Adds a new top section and material to the added tab
            materialUC.Location = new Point(0, 105);
            TabPage tp = this.tabSection1;
            tp.Controls.Add(topUC);
            tp.Controls.Add(materialUC);

            //sets the place for controls to be place on the first tab
            controlPossitions[0] = 105;
        }

        private void btnNewSection_Click(object sender, EventArgs e)
        {
            //inittializes new usercontrols
            topUC = new SectionUserControl();
            materialUC = new MaterialUserControl();

            // Adds a new top section and material to the added tab
            materialUC.Location = new Point(0, 105);
            TabPage tp = new TabPage("Section " + (tabSections.SelectedIndex + 2));
            tp.AutoScroll = true;
            tp.Controls.Add(topUC);
            tp.Controls.Add(materialUC);
            tp.BackColor = System.Drawing.Color.White;
            tabSections.TabPages.Add(tp);
            tabSections.SelectedTab = tp;

            //creates a starting point for new controls in the section
            controlPossitions[tabSections.SelectedIndex] = 105;

        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {

            //increments the possition for control placemenet based on the tab
            controlPossitions[tabSections.SelectedIndex] += 30;

            //inittializes new usercontrol
            materialUC = new MaterialUserControl();
            materialUC.Location = new Point(0, controlPossitions[tabSections.SelectedIndex]);
            tabSections.SelectedTab.Controls.Add(materialUC);

        }

        private void btnPrintQuote_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("\nNew Test\n");
            //holds all the tabs in the form
            TabControl.TabPageCollection tabs = tabSections.TabPages;

            //iterates through tabs
            foreach(TabPage tab in tabs){

                Debug.WriteLine("New Tab\n ---------\n");

                //holds all the user controls in the tab
                UserControl.ControlCollection ucs = tab.Controls;

                //iterates through user controls
                foreach (UserControl uc in ucs) {

                    Debug.Write("New User Control \n---------------\n");

                    if (uc.ToString() == "DellMechanicalQuoteSystem.SectionUserControl")
                    {
                        Debug.WriteLine(uc.Controls["txtSectionTitle"].Text);

                    }
                    else
                    {

                        Debug.WriteLine(uc.Controls["numQuantity"].Text);
                        Debug.WriteLine(uc.Controls["cmbMaterialType"].Text);
                        Debug.WriteLine("\n");

                    }
                }
            }
        }

        private void btCalculateSection_Click(object sender, EventArgs e)
        {
            
            TabPage curTab = tabSections.SelectedTab;

            Debug.WriteLine(tabSections.SelectedIndex);
            //creates a new section in the quote
            quote.sections.Add(new Section());
            Section curSection = quote.sections.ToArray()[tabSections.SelectedIndex];

            if (curTab.Controls[0].Controls["txtSectionTitle"].Text != "")
            {
                //sets the selected tabs title to the section title
                curTab.Text = curTab.Controls[0].Controls["txtSectionTitle"].Text;

                //holds all the user controls in the tab
                UserControl.ControlCollection ucs = curTab.Controls;

                //iterates through user controls
                foreach (UserControl uc in ucs)
                {

                    // used to set the array position in the sections class 
                    // -1 to start from 0 since the first uc is the title
                    int i = ucs.IndexOf(uc) - 1;


                    if (uc.ToString() == "DellMechanicalQuoteSystem.SectionUserControl")
                    {
                        curSection.title = uc.Controls["txtSectionTitle"].Text;
                    }
                    else
                    {
                        // sets all the values in the curent user contre
                        curSection.materialTypes.Add(uc.Controls["cmbMaterialType"].Text);
                        curSection.quantity.Add(int.Parse(uc.Controls["numQuantity"].Text));
                        curSection.materialUnitCosts.Add(double.Parse(uc.Controls["lblMaterialUnitCost"].Text));
                        curSection.labourUnitCosts.Add(double.Parse(uc.Controls["lblLabourUnitCost"].Text));
                        curSection.labourCosts.Add(double.Parse(uc.Controls["lblLabourCost"].Text));
                        curSection.materialCosts.Add(double.Parse(uc.Controls["lblMaterialCost"].Text));

                    }
                }

                //calculates and sets the section totals
                curSection.calc_sectionTotals();

                //sets the section labels to the calculated totals
                lblSecLabourCost.Text = curSection.totalLabourCost.ToString();
                lblSecMaterialCost.Text = curSection.totalMaterialCost.ToString();
                lblSecTotal.Text = curSection.totalCost.ToString();

                //calculates the totals for the whole quote
                quote.calcTotals();

                //sets the labels for the quote totals
                lblTotalCost.Text = quote.totalCost.ToString();
                lblTotalMaterial.Text = quote.totalMaterialCost.ToString();
                lblTotalLabour.Text = quote.totalLabourCost.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a section title");
            }

            
        }

        private void TabSections_SelectedIndexChanged(object sender, EventArgs e)
        {

            //FIND WAY TO AVOID CRASH
            //Section curSection = quote.sections.ToArray()[tabSections.SelectedIndex];

            ////sets the section labels to the calculated totals
            //lblSecLabourCost.Text = curSection.totalLabourCost.ToString();
            //lblSecMaterialCost.Text = curSection.totalMaterialCost.ToString();
            //lblSecTotal.Text = curSection.totalCost.ToString();
        }

    }
}
