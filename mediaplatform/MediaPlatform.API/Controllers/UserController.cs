using System.Collections.Generic;
using MediaPlatform.Storing.Databases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediaPlatform.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class UserController : ControllerBase
   {
      private MediaPlatformSingleton _mps = MediaPlatformSingleton.Instance;
      private readonly ILogger<HomeController> _logger;

      public UserController(ILogger<HomeController> logger)
      {
         _logger = logger;
      }

    [HttpGet]
    public void Get()
    {
      
    }

    [HttpPost]
    public void Post()
    {

    }

    [HttpPut]
    public void Put()
    {

    }

    [HttpDelete]
    public void Delete()
    {

    }
  }
}