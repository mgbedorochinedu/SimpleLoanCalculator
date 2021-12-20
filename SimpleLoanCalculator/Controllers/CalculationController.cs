using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleLoanCalculator.Model;
using SimpleLoanCalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLoanCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        private readonly ICalculationService _calculationService;
        private readonly ILogger<CalculationController> _logger;

        public CalculationController(ICalculationService calculationService, ILogger<CalculationController> logger)
        {
            _calculationService = calculationService;
            _logger = logger;
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400, Type = typeof(void))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Calculate([FromBody] Calculation calculation)
        {
            try
            {
                return Ok(_calculationService.Calculate(calculation));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(Calculate)}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }

        }

    }
}
