using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwaggerResponse2.Filters;
using SwaggerResponse2.Models;
using SwaggerResponse2.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerResponse2.Controllers
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
        /// descricao action
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

        [MeuFiltro]
        [HttpPost]
        public IActionResult Registrar(Pessoa pessoa)
        {
            //if (!ModelState.IsValid)
            //{
            //    var listaDeErros = new ListaDeErros(ModelState
            //        .SelectMany(sm => sm.Value.Errors)
            //        .Select(s => s.ErrorMessage));
            //    //Quem não fala o que quer aceita o que vier!
            //    //Se não for definido o objeto devolvido pelo método de retorno
            //    //Ele devolve os dados padrão
            //    return BadRequest();
            //}

            return Created("Caminho para consulta", pessoa);
        }
    }
}
