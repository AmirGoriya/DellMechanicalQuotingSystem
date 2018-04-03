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
        public int possition { get; set; }

        public MaterialUserControl(int pos)
        {
            InitializeComponent();
            possition = pos;
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

        private void lblLabourCost_Click(object sender, EventArgs e)
        {

        }
    }
}
