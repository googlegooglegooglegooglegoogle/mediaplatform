using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MediaPlatformClient.MVC.Singletons;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Newtonsoft.Json;

namespace mediaplatform_client.MediaPlatformClient.MVC.Controllers
{
   public class VideoController : Controller
   {
      private static readonly MediaPlatformSingleton _mps = MediaPlatformSingleton.Instance;
      public const string SessionUsername = "";

      public IActionResult Index()
      {

         var res = _mps.Client.GetAsync($"http://api/video/demi").GetAwaiter().GetResult();
         var films = JsonConvert.DeserializeObject<List<string>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());
         return View(films);
      }

      // public IActionResult Index()
      // {
      //   var res = _http.GetAsync("").GetAwaiter().GetResult();
      //   var videos = JsonConvert.DeserializeObject<List<VideoViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());

      //   return View(videos);
      // }
   }
}
