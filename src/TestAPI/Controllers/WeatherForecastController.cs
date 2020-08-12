using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestApp;

namespace TestAPI.Controllers
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

        [HttpGet]
        public IActionResult Get()
        {
            var data = new List<TestModel> { 
                new TestModel
                {
                    Lastname = "213", Firstname = "abc"
                },
                new TestModel
                {
                    Lastname = "ytu", Firstname = "xcv"
                },
                new TestModel
                {
                    Lastname = "jgj", Firstname = "23213"
                },
                new TestModel
                {
                    Lastname = "099", Firstname = "bvcvb"
                },
            };

            return Ok(data);
        }
    }
}
