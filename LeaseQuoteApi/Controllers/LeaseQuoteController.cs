using Microsoft.AspNetCore.Mvc;
using LeaseQuoteApi.Models;

namespace LeaseQuoteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeaseQuoteController : ControllerBase
    {
        private readonly LeaseCalculatorService _service;
        private readonly ILogger<LeaseQuoteController> _logger;

        public LeaseQuoteController(LeaseCalculatorService service, ILogger<LeaseQuoteController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post([FromBody] LeaseQuoteRequest request)
        {
            _logger.LogInformation("Received quote request: {@request}", request);

            if (string.IsNullOrEmpty(request.CarModel) || request.DurationMonths <= 0)
                return BadRequest("Invalid input");

            var quote = _service.CalculateQuote(request);
            return Ok(quote);
        }

    }
}

