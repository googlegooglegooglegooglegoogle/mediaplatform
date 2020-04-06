using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace mediaplatform_client.MediaPlatformClient.MVC.Controllers
{
  public class AccountController : Controller
  {
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
        HttpContext.Session.SetString(SessionUsername, "Mr. Demi Demi");
        return RedirectToAction("Index", "User");
      }
      return View(accountViewModel);
    }
  }
}