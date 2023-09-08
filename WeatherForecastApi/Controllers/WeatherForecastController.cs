using Microsoft.AspNetCore.Mvc;
using WeatherForecastApi.Models;
using WeatherForecastApi.Services;

namespace WeatherForecastApi.Controllers;

[ApiController]
public class WeatherForecastController : ControllerBase
{
    [HttpGet("api/forecast")]
    public IEnumerable<WeatherForecastDay> Get() => WeatherForecastService.GetForecast();
}
