using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DellMechanicalQuoteSystem
{
    public partial class MaterialUserControl : UserControl
    {
        //ensures a material was added before calculating the cost for material
        private bool isMaterialAdded = false;

        public MaterialUserControl()
        {
            InitializeComponent();

            //fills the combo box with the data
            try
            {
                this.materialTableAdapter.Fill(this.dellMechanicalDBDataSet.Material);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void numQuantity_Enter(object sender, EventArgs e)
        {
            numQuantity.Select(0, numQuantity.Text.Length);
        }

        private void cmbMaterialType_Leave(object sender, EventArgs e)
        {
            isMaterialAdded = true;

        }

        private void numQuantity_Leave(object sender, EventArgs e)
        {
            double labourUnitCost;
            double materialUnitCost;
            double labourCost;
            double materialCost;

            if (isMaterialAdded)
            {
                //gets the row that coresponds to the id returned from the combobox
                DataRow[] rows = dellMechanicalDBDataSet.Tables["Material"].Select("id = " + cmbMaterialType.SelectedValue);
                DataRow row = rows[0];

                //storesd the coresponding material unit price and labour unit price
                materialUnitCost = (double)row["materialUnitPrice"];
                labourUnitCost = (double)row["labourUnitPrice"];

                //calculaes the total labour and unit cost
                labourCost = labourUnitCost * (double)numQuantity.Value;
                materialCost = materialUnitCost * (double)numQuantity.Value;

                //sets the values to the labels
                lblLabourUnitCost.Text = labourUnitCost.ToString();
                lblMaterialUnitCost.Text = materialUnitCost.ToString();
                lblLabourCost.Text = labourCost.ToString();
                lblMaterialCost.Text = materialCost.ToString();
                

            }

        }
    }
}
