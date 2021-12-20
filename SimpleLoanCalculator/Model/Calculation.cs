using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLoanCalculator.Model
{
    public class Calculation
    {
        public decimal Amount { get; set; }
        public double Rate { get; set; }
        public int Years { get; set; }
    }
}
