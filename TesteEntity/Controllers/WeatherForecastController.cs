using Microsoft.AspNetCore.Mvc;
using TesteEntity.Domain.DTOs.InterfacesRepositories.InterfacesServices;

namespace TesteEntity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IProductsService _productsService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IProductsService productsService)
        {
            _logger = logger;
            _productsService = productsService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productsService.GetProductsAsync());
        }
    }
}