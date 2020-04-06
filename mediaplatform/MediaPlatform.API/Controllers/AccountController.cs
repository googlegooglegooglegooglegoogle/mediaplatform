using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlatform.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediaPlatform.API.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class AccountController : ControllerBase
   {

      [HttpGet]
      public User Get()
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
   }
}
