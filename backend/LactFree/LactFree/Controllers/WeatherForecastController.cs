using LactFree.Infraestructure;
using LactFree.User;
using Microsoft.AspNetCore.Mvc;

namespace LactFree.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly TokenProvider _provider;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, TokenProvider provider)
    {
        _logger = logger;
        _provider = provider;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        var user = new UserModel()
        {
            Id = Guid.NewGuid(),
            Email = "mariaelisagmt@gmail.com",
            Password = "123",
            Name = "Maria Elisa"
        };

        var token = _provider.Create(user);
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
