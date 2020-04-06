using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Net.Http;

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
        /*
        make api call and send in avm.Username, avm.Password
        response = something

        if (response == username and password are correct)
        {
          await _signInManager.SignInAsync(user, false);
          return RedirectToAction("Index", "Home");
        }
        */
        // var res = _httpClient.GetAsync($"http://api/account/{accountViewModel.Username}/{accountViewModel.Password}");
        var res = _httpClient.GetAsync($"http://api/account/{accountViewModel.Username}/{accountViewModel.Password}").GetAwaiter().GetResult();
        var something = res.Content.ReadAsStringAsync().GetAwaiter().GetResult();

        var name = "";
        if (something == null)
        {
          name = "the name is null";
        }
        else
        {
          name = "the name is not null";
        }

        HttpContext.Session.SetString(SessionUsername, something.ToString());
        return RedirectToAction("Index", "User");
      }
      return View(accountViewModel);
    }
  }
}