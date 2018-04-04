using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellMechanicalQuoteSystem
{
    class Quote
    {
        //holds all the sections in the quote
        Section[] sections { get; set; }

        //holds the title of the quote
        string title { get; set; }

        //holds the totals for the quote
        double totalMaterialCost { get;}
        double totalLabourCost { get; }
        double totalLabourHours { get;}
        double totalCost { get; }

        //holds the extra costs for the quote
        double extraCosts { get; set; }

        //holds the cost dedeuctions for the quote
        double costDedeductions { get; set; }
    }
}
