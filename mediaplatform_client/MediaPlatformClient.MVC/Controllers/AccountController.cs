using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Net.Http;
using System;
using MediaPlatformClient.MVC.Singletons;

namespace mediaplatform_client.MediaPlatformClient.MVC.Controllers
{
  public class AccountController : Controller
  {
    private static readonly MediaPlatformSingleton _mps = MediaPlatformSingleton.Instance;
    public const string SessionUsername = "";
    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Login(AccountViewModel accountViewModel)
    {      
      if (ModelState.IsValid)
      {
        var res = _mps.Client.GetAsync($"http://api/account/{accountViewModel.Username}/{accountViewModel.Password}").GetAwaiter().GetResult();
        var something = res.Content.ReadAsStringAsync().GetAwaiter().GetResult().ToString();
        //something should be a string called 'True' or 'False'

        // var name = "";
        // if (Boolean.TryParse(something))
        //   name = accountViewModel.Username;
        // else
        //   name = "not a bool";

        HttpContext.Session.SetString(SessionUsername, something);
        return RedirectToAction("Index", "User");
      }
      return View(accountViewModel);
    }
  }
}