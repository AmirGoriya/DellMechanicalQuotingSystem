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
    public partial class MaterialManagement : Form
    {
        public MaterialManagement()
        {
            InitializeComponent();
        }

        private void MaterialManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dellMechanicalDBDataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.dellMechanicalDBDataSet.Material);
            
        }

        private void btnUpdateMaterials_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.materialBindingSource.EndEdit();
                this.materialTableAdapter.Update(this.dellMechanicalDBDataSet.Material);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
