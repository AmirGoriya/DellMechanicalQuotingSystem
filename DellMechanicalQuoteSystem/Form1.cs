using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DellMechanicalQuoteSystem
{
    public partial class formMain : Form
    {
        //holds the count for the number of tabs in the form
        private int tabCount = 2;

        //holds the user controls that are dynmically added to the form
        SectionUserControl topUC;
        MaterialUserControl materialUC;

        public formMain()
        {
            InitializeComponent();

            //inittializes new usercontrols
            topUC = new SectionUserControl();
            materialUC = new MaterialUserControl(105);
            
            // Adds a new top section and material to the added tab
            materialUC.Location = new Point(0, 105);
            TabPage tp = this.tabSection1;
            tp.Controls.Add(topUC);
            tp.Controls.Add(materialUC);
        }

        private void btnNewSection_Click(object sender, EventArgs e)
        {
            //inittializes new usercontrols
            topUC = new SectionUserControl();
            materialUC = new MaterialUserControl(105);

            // Adds a new top section and material to the added tab
            materialUC.Location = new Point(0, 105);
            TabPage tp = new TabPage("Section " + tabCount.ToString());
            tp.AutoScroll = true;
            tp.Controls.Add(topUC);
            tp.Controls.Add(materialUC);
            tabSections.TabPages.Add(tp);
            tabSections.SelectedTab = tp;

            //increments the count of tabs on the page
            tabCount++;
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {

            int possition = materialUC.possition + 30;

            //inittializes new usercontrol
            materialUC = new MaterialUserControl(possition);
            materialUC.Location = new Point(0, possition);
            tabSections.SelectedTab.Controls.Add(materialUC);

        }

        private void btnPrintQuote_Click(object sender, EventArgs e)
        {
            TabControl.TabPageCollection tabs = tabSections.TabPages;

            MessageBox.Show(tabSections.TabPages[0].Controls[1].Controls["cmbMaterialType"].Text.ToString());
            MessageBox.Show(tabSections.TabPages[0].Controls[1].Controls["numQuantity"].Text.ToString());
            
            foreach(TabPage tab in tabs){
                
                //MessageBox.Show(tab.ToString)
            }
        }
    }
}
