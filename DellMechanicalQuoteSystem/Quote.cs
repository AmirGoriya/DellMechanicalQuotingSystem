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
        public Section[] sections { get; set; }

        //holds the title of the quote
        public string title { get; }

        //holds the totals for the quote
        double totalMaterialCost { get;}
        double totalLabourCost { get; }
        double totalLabourHours { get;}
        double totalCost { get; }

        //holds the extra costs for the quote
        double extraCosts { get; set; }

        //holds the cost dedeuctions for the quote
        double costDedeductions { get; set; }
        public Quote(string title)
        {
            this.title = title;
        }
    }
}
