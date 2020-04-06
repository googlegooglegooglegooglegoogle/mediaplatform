using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlatform.Domain.Models;
using MediaPlatform.Storing.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediaPlatform.API.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class AccountController : ControllerBase
   {
      private static readonly string[] Summaries = new[]
      {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
      };

      public MediaPlatformRepository _mpr;
      private MediaPlatformSingleton _mps;

      public AccountController(MediaPlatformRepository repo)
      {
         _mpr = repo;
         _mps = new MediaPlatformSingleton(_mpr);
      }

      [HttpGet("{username}/{password}")]
      public bool AccountLogin(string username, string password)
      {
        if (ModelState.IsValid)
        {
          return _mps.CheckLogin(username, password);
        }
        return false;
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
   }
}
