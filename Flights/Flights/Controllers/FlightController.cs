using Flights.ReadModels;
using Microsoft.AspNetCore.Mvc;

namespace Flights.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly ILogger<FlightController> _logger;

        public FlightController(ILogger<FlightController> logger)
        {
            _logger = logger;
        }

        Random random = new Random();

        [HttpGet]
        public IEnumerable<FlightRm> Search()
            => new FlightRm[]
            {
                new ( Guid.NewGuid(),
                    "American Airlines",
                    random.Next(90, 5000).ToString(),
                    new TimePlaceRm("Los Angeles", DateTime.Now.AddHours(random.Next(1, 3))),
                    new TimePlaceRm("Istanbul", DateTime.Now.AddHours(random.Next(4, 10))),
                        random.Next(1, 853)),
                new ( Guid.NewGuid(),
                    "Deutsche BA",
                    random.Next(90, 5000).ToString(),
                    new TimePlaceRm("Le Bourget", DateTime.Now.AddHours(random.Next(1, 10))),
                    new TimePlaceRm("Zagreb", DateTime.Now.AddHours(random.Next(4, 15))),
                        random.Next(1, 853))
            };
    }
}