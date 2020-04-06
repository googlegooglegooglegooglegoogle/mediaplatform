using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlatform.Domain.Models;
using MediaPlatform.Storing.Databases;
using MediaPlatform.Storing.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediaPlatform.API.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class AccountController : ControllerBase
   {
      private MediaPlatformSingleton _mps = MediaPlatformSingleton.Instance;
      private readonly ILogger<HomeController> _logger;

      public AccountController(ILogger<HomeController> logger, MediaPlatformDbContext dbContext)
      {
         _mps.SetDbContext(dbContext);
         _logger = logger;
      }

      [HttpGet("{username}/{password}")]
      public bool AccountLogin(string username, string password)
      {
        if (ModelState.IsValid)
        {
          return _mps.CheckLogin(username, password);
        }
        return false;
      }
   }
}
