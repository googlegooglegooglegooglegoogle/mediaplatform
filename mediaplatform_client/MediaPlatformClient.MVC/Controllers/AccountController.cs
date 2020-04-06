using Microsoft.AspNetCore.Mvc;

namespace mediaplatform_client.MediaPlatformClient.MVC.Controllers
{
  public class AccountController : Controller
  {
    public IActionResult Index()
    {
        return View();
    }
    // public IActionResult Index()
    // {
    //   return View();
    // }
  }
}