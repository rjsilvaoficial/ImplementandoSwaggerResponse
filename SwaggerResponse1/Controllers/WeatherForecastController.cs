using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwaggerResponse1.Models;
using SwaggerResponse1.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerResponse1.Controllers
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
        /// descricao da action
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

        [HttpPost]
        public IActionResult Registrar(Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ListaDeErros(ModelState
                    .SelectMany(sm=>sm.Value.Errors)
                    .Select(s=>s.ErrorMessage)));
            }

            return Created("uri de consulta", pessoa);
        }

    }
}
