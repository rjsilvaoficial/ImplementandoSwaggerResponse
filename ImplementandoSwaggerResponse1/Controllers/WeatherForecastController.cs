using ImplementandoSwaggerResponse1.Models;
using ImplementandoSwaggerResponse1.Validations;
using ImplementandoSwaggerResponse1.Validations.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementandoSwaggerResponse1.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Descricao do metodo/action atual
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        /// <summary>
        /// Descricao do metodo/action Registrar()
        /// </summary>
        /// <param name="pessoa"></param>
        /// <returns></returns>
        [SwaggerResponse(statusCode: 201, description: "mimimimi", Type = typeof(Pessoa))]
        [SwaggerResponse(statusCode: 400, description: "mimimimi", Type = typeof(ListadoraDeErros))]
        [MeuFiltroPersonalizado]
        [HttpPost]
        public IActionResult Registrar(Pessoa pessoa)
        {

            return Created("MINHA URL", pessoa);
        }
    }
}
