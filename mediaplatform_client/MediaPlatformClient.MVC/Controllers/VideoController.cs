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

namespace mediaplatform_client.MediaPlatformClient.MVC.Controllers
{
  public class VideoController : Controller
  {
    private readonly HttpClient _http = new HttpClient();

    public IActionResult Index()
    {
      var res = _http.GetAsync("").GetAwaiter().GetResult();
      var videos = JsonConvert.DeserializeObject<List<VideoViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());

      return View(videos);
    }
  }
}
