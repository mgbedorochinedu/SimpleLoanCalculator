using SimpleLoanCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLoanCalculator.Services.Interfaces
{
    public interface ICalculationService
    {
        decimal Calculate(Calculation calculation);
    }
}
