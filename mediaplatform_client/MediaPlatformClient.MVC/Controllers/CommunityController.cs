using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Newtonsoft.Json;
using MediaPlatformClient.MVC.Singletons;

namespace mediaplatform_client.MediaPlatformClient.MVC.Controllers
{
  public class CommunityController : Controller
  {
    private static readonly MediaPlatformSingleton _mps = MediaPlatformSingleton.Instance;
    public const string SessionUsername = "";
    public IActionResult Index()
    {
      List<CommunityViewModel> cvms = new List<CommunityViewModel>() 
      {
        new CommunityViewModel() {ID = 1, Name = "Hello"},
        new CommunityViewModel() {ID = 2, Name = "Goodbye"},
      };
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
