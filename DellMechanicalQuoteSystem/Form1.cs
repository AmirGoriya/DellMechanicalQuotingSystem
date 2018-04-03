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

        public formMain()
        {
            InitializeComponent();
        }

        private void btnNewSection_Click(object sender, EventArgs e)
        {
            SectionUserControl  uc = new SectionUserControl();
            TabPage tp = new TabPage("Section " + tabCount.ToString());
            tp.Controls.Add(uc);
            this.tabSections.TabPages.Add(tp);

            tabCount++;
        }
    }
}
