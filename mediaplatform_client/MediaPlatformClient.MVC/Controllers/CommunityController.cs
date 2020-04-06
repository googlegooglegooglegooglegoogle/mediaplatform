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
   public class CommunityController : Controller
   {
      private static readonly MediaPlatformSingleton _mps = MediaPlatformSingleton.Instance;
      public IActionResult Index()
      {

         var res = _mps.Client.GetAsync($"http://api/community").GetAwaiter().GetResult();
         var cvms = JsonConvert.DeserializeObject<List<CommunityViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());
         return View(cvms);
      }

      // public IActionResult Index()
      // {
      //   var res = _http.GetAsync("").GetAwaiter().GetResult();
      //   var users = JsonConvert.DeserializeObject<List<CommunityViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());

      //   return View(users);
      // }
   }
}
