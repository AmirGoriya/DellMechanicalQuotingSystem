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
        public MaterialUserControl()
        {
            InitializeComponent();
            numQuantity.Enter += new EventHandler(numQuantity_Enter);
        }

        private void numQuantity_Enter(object sender, EventArgs e)
        {
            numQuantity.Select(0, numQuantity.Text.Length);
        }

        private void cmbMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
