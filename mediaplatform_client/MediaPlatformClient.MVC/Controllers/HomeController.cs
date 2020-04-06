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
using Models;
using MediaPlatformClient.MVC.Singletons;

namespace MediaPlatformClient.MVC.Controllers
{
   public class HomeController : Controller
   {
      private static readonly MediaPlatformSingleton _mps = MediaPlatformSingleton.Instance;

      private readonly ILogger<HomeController> _logger;

      public HomeController(ILogger<HomeController> logger)
      {
         _logger = logger;
      }

      public IActionResult Index() //Index should display videos, users who uploaded them, and community name?
      {
         List<HomeViewModel> hvms = new List<HomeViewModel>() 
         {
          new HomeViewModel() { Title = "SWEET EATS", UploadedBy = "Guy Fieri", CommunityName = "Flavor Town" },
          new HomeViewModel() { Title = "YESFRED", UploadedBy = "FredFredBurger", CommunityName = "Gumboooo" },
         };
         return View(hvms);
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
