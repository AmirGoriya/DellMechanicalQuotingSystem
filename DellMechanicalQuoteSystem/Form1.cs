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
    public partial class formMain : Form
    {

        //holds the possition for controls to be placed on each tab
        int[] controlPossitions = new int[80];

        //holds the user controls that are dynmically added to the form
        SectionUserControl topUC;
        MaterialUserControl materialUC;

        public formMain()
        {
            InitializeComponent();

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
            //sets the selected tabs title to the section title
            curTab.Text = curTab.Controls[0].Controls["txtSectionTitle"].Text;
        }

    }
}
