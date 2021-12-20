using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SimpleLoanCalculator.Model;
using SimpleLoanCalculator.Services;
using SimpleLoanCalculator.Services.Interfaces;
using SimpleLoanCalculator.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLoanCalculator.ServiceExtension
{
    public static class DependencyInjectionExtensions
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IValidator<Calculation>, CalculationValidator>();
            services.AddScoped<ICalculationService, CalculationService>();
        }
    }
}
