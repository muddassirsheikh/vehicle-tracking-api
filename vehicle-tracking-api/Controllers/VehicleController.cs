using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracking.Helpers;
using VehicleTracking.Models;

namespace VehicleTracking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public VehicleController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new Vehicle
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
            return Store.Instance.Vehicles;
        }

        [HttpPost]
        public IEnumerable<Vehicle> Scan(Track track)
        {
            var veh = Store.Instance.Vehicles.FirstOrDefault(v => v.Id == track.VehicleId);
            veh?.Tracks.Add(track);
            return Store.Instance.Vehicles;
        }
    }
}
