using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Test.DataAccess.Core;
using Test.DataAccess.Entities;

namespace Test.Controllers
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

        [HttpGet]
        public void Test()
        {
            Container container = new Container();
            container
            BootStrapper.Configure(container);
            container.Verify();
            using (container.BeginLifetimeScope())
            {
                MainActivity entryPoint = container.GetInstance<MainActivity>();
                entryPoint.test();
            }
        }
    }

    public class SomeActivity
    {
        public SomeActivity(IRepository<Department> departments) { }
    }

    public class MainActivity
    {
        private readonly IUnitOfWork _unitOfWork;
        public MainActivity(IUnitOfWork unitOfWork, SomeActivity activity)
        {
            _unitOfWork = unitOfWork;
        }

        public void test()
        {
            _unitOfWork.Commit();
        }
    }
}
