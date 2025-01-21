using Microsoft.AspNetCore.Mvc;
using Tariff_Comparison.Models;
using Tariff_Comparison.Services;

namespace Tariff_Comparison.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TariffsController : ControllerBase
    {
        private readonly TariffService _tariffService;

        public TariffsController(TariffService tariffService)
        {
            _tariffService = tariffService;
        }

        [HttpGet("compare")]
        public ActionResult<IEnumerable<TariffResult>> CompareTariffs([FromQuery] decimal consumption)
        {
            if (consumption <= 0)
            {
                return BadRequest("Consumption must be greater than 0");
            }

            var results = _tariffService.CalculateAnnualCost(consumption);
            return Ok(results);
        }
    }
}
