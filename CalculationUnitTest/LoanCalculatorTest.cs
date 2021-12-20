using NUnit.Framework;
using SimpleLoanCalculator.Model;
using SimpleLoanCalculator.Services;
using SimpleLoanCalculator.Services.Interfaces;
using Xunit;

namespace CalculationUnitTest
{
    public class LoanCalculatorTest
    {

        private ICalculationService _calculationService;

        public LoanCalculatorTest()
        {
            _calculationService = new CalculationService();
        }

        [Fact]
        public void Calculationtest()
        {
            // Arrange
            var calc = new Calculation { Amount = 10000, Rate = 5, Years = 1 };

            // Act
            var result = _calculationService.Calculate(calc);

            // Assert
            Assert.Equals(855, result);


        }
    }
}