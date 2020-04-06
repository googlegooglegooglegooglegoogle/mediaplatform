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

namespace mediaplatform_client.MediaPlatformClient.MVC.Controllers
{
  public class UserController : Controller
  {
    public const string SessionName = "_Name";
    private readonly HttpClient _http = new HttpClient();

    public IActionResult Index()
    {
      ViewBag.Username = HttpContext.Session.GetString(SessionName);
      return View();
    }
    
    // public IActionResult Index()
    // {
    //   var res = _http.GetAsync("").GetAwaiter().GetResult();
    //   var users = JsonConvert.DeserializeObject<List<UserViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());

    //   return View(users);
    // }
  }
}
