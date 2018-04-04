using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellMechanicalQuoteSystem
{
    class Section
    {
        //holds teh section title
        string title { get; set; }

        //holds the totals for the section
        double totalMaterialCost { get; }
        double totalLabourCost { get; }
        double totalLabourHours { get; }
        double totalCost { get; }

        //holds the values for each material in the section
        string[] materialTypes { get; set; }
        int[] quantity { get; set; }
        double[] materialUnitCosts { get; }
        double[] materialCosts { get; }
        double[] labourUnitCosts { get; }
        double[] labourCosts { get; }

        //used to calculate all the section totals
        public void calc_sectionTotals()
        {


        }

        private void calc_totalMaterialCost()
        {

        }
        private void calc_totalLabourCost()
        {

        }
    }
}
