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
        }

        public int quantiy
        {
            get
            {
                return (int)numQuantity.Value;
            }
        }
        public string materialType
        {
            get
            {
                return cmbMaterialType.Text;
            }
        }

        private void cmbMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
