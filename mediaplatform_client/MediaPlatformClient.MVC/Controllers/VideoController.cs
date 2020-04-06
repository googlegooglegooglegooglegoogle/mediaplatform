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
using MediaPlatformClient.MVC.Singletons;

namespace mediaplatform_client.MediaPlatformClient.MVC.Controllers
{
   public class VideoController : Controller
   {
      private static readonly MediaPlatformSingleton _mps = MediaPlatformSingleton.Instance;

      public IActionResult Index()
      {

         var res = _mps.Client.GetAsync($"http://api/video/demi").GetAwaiter().GetResult();
         var videos = JsonConvert.DeserializeObject<List<VideoViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());
         return View("index", videos);
      }

      // public IActionResult Index()
      // {
      //   var res = _http.GetAsync("").GetAwaiter().GetResult();
      //   var videos = JsonConvert.DeserializeObject<List<VideoViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());

      //   return View(videos);
      // }
   }
}
