using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediaPlatformClient.MVC.Models;
using System.Net.Http;
using Newtonsoft.Json;
using MediaPlatform.MVC.Models;

namespace MediaPlatformClient.MVC.Controllers
{
   public class HomeController : Controller
   {
      private static readonly HttpClient _http = new HttpClient();
      private readonly ILogger<HomeController> _logger;

      public HomeController(ILogger<HomeController> logger)
      {
         _logger = logger;
      }

      public IActionResult Index()
      {
         var res = _http.GetAsync("http://localhost:4000/WeatherForecast").GetAwaiter().GetResult();
         var temps = JsonConvert.DeserializeObject<List<WeatherForecastViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());
         
         return View(temps);
      }

      public IActionResult Privacy()
      {
         return View();
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}
