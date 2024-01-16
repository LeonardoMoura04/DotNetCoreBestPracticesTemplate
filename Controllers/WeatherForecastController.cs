using DotNetCoreBestPracticesTemplate.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreBestPracticesTemplate.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<WeatherForecastController> _logger;
		private readonly IEmployeeService _employeeService;

		public WeatherForecastController(ILogger<WeatherForecastController> logger, IEmployeeService employeeService)
		{
			_logger = logger;
			_employeeService = employeeService;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			try
			{
				return Enumerable.Range(1, 5).Select(index => new WeatherForecast
				{
					Employee = _employeeService.GetEmployeeById(0),
					Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
					TemperatureC = Random.Shared.Next(-20, 55),
					Summary = Summaries[Random.Shared.Next(Summaries.Length)]
				})
				.ToArray();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex.Message, ex);
				throw;
			}
		}
	}
}
