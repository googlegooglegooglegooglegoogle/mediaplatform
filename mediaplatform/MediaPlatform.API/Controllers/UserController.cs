using System.Collections.Generic;
using MediaPlatform.Storing.Databases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediaPlatform.Domain.Models;

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

    // [HttpGet]
    [HttpGet("{username}")]
    public User Get(string username) //string username
    {
      if (ModelState.IsValid)
      {
        return _mps.GetUser(username);
      }
      return null;
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