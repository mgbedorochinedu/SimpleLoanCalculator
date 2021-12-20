using SimpleLoanCalculator.Model;
using SimpleLoanCalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLoanCalculator.Services
{
    public class CalculationService : ICalculationService
    {
        public decimal Calculate(Calculation calculation)
        {
            var rate = calculation.Rate > 0 ? calculation.Rate / 100 : calculation.Rate;
            var termInMonths = calculation.Years * 12;

            return calculation.Amount *
                ((decimal)Math.Pow(1 + (rate / 12), termInMonths) * ((decimal)rate / 12)) /
                ((decimal)Math.Pow(1 + (rate / 12), termInMonths) - 1);
        }
    }
}
