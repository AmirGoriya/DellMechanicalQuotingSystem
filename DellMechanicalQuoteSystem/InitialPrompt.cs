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
    public partial class InitialPrompt : Form
    {

        public InitialPrompt()
        {
            InitializeComponent();
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {

            if (txtTitle.Text != "")
            {
                //launches the main quoting form and closes the initialPrompt
                MainForm mainForm = new MainForm(txtTitle.Text);
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a quote title");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //launches the main quoting form and closes the initialPrompt
            MaterialManagement materialMgmt =  new MaterialManagement();
            this.Hide();
            materialMgmt.ShowDialog();
            this.Close();
        }
    }
}
