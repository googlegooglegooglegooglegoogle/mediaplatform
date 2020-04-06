using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Newtonsoft.Json;
using MediaPlatformClient.MVC.Singletons;

namespace mediaplatform_client.MediaPlatformClient.MVC.Controllers
{
  public class UserController : Controller
  {
    private static readonly MediaPlatformSingleton _mps = MediaPlatformSingleton.Instance;
    public IActionResult Index()
    {
      ViewBag.Username = HttpContext.Session.GetString(_mps.SessionUsername);
      return View();
    }

    [HttpGet]
    public IActionResult UserCommunities(string id) //should take argument strind id, no argument for dev purposes
    {
      //get list of communities api httpcall
      // List<CommunityViewModel> cvms = new List<CommunityViewModel>() 
      // {
      //   new CommunityViewModel() { ID = 1, Name = "A" },
      //   new CommunityViewModel() { ID = 2, Name = "B" }
      // };

      var res = _mps.Client.GetAsync($"http://api/user/{id}").GetAwaiter().GetResult();
      var something = res.Content.ReadAsStringAsync().GetAwaiter().GetResult().ToString();
      // var uvm = JsonConvert.DeserializeObject<List<UserViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());
      ViewBag.something = something;
      return View();
    }

    [HttpGet]
    public IActionResult UserVideos() //should take argument strind id, no argument for dev purposes
    {
      //get list of videos api httpcall
      List<VideoViewModel> vvms = new List<VideoViewModel>() 
      {
        new VideoViewModel() { ID = 1, Title = "A", Duration = 100, UploadedBy = "Fred" },
        new VideoViewModel() { ID = 2, Title = "B", Duration = 200, UploadedBy = "Belotte" },
      };
      return View(vvms);
    }

    // public IActionResult Index()
    // {
    //   var res = _http.GetAsync("").GetAwaiter().GetResult();
    //   var users = JsonConvert.DeserializeObject<List<UserViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());

    //   return View(users);
    // }
  }
}
