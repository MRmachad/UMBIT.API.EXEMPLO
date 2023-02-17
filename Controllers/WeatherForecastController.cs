using Microsoft.AspNetCore.Mvc;
using UMBIT.API.EXEMPLO.Servico;
using UMBIT.Core.Repositorio;

namespace UMBIT.API.EXEMPLO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private IServicoDeGato ServicoDeGato;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IServicoDeGato ServicoDeGato)
        {
            this.ServicoDeGato = ServicoDeGato;

            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {

            this.ServicoDeGato.AdicionaObjeto(new model.Gato());
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

        }
    }
}