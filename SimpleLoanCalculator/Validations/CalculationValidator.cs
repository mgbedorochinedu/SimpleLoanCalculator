﻿using FluentValidation;
using SimpleLoanCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLoanCalculator.Validations
{
    public class CalculationValidator : AbstractValidator<Calculation>
    {
        public CalculationValidator()
        {
            RuleFor(c => c.Amount)
                .GreaterThan(0).WithMessage("Amount must be greater than 0");

            RuleFor(c => c.Rate)
                .GreaterThan(0).WithMessage("Rate must be greater than 0%")
                .LessThan(100).WithMessage("Rate must be less than 100%");

            RuleFor(c => c.Years)
                .GreaterThan(0).WithMessage("Years must be greater than 0")
                .LessThan(100).WithMessage("Years must be less than 100");

        }
    }
}
