using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Net.Http;
using System;

namespace mediaplatform_client.MediaPlatformClient.MVC.Controllers
{
  public class AccountController : Controller
  {
    private readonly HttpClient _httpClient = new HttpClient();
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
        var res = _httpClient.GetAsync($"http://api/account/{accountViewModel.Username}/{accountViewModel.Password}").GetAwaiter().GetResult();
        var something = res.Content.ReadAsStringAsync().GetAwaiter().GetResult().ToString();
        //something should be a string called 'True' or 'False'

        // var name = "";
        // if (Boolean.TryParse(something))
        //   name = accountViewModel.Username;
        // else
        //   name = "not a bool";

        HttpContext.Session.SetString(SessionUsername, accountViewModel.Username);
        return RedirectToAction("Index", "User");
      }
      return View(accountViewModel);
    }
  }
}