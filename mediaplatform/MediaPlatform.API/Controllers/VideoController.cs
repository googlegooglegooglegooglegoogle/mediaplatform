using System.Collections.Generic;
using System.Linq;
using MediaPlatform.Domain.Models;
using MediaPlatform.Storing.Databases;
using MediaPlatform.Storing.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediaPlatform.API.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class VideoController : ControllerBase
   {
      private MediaPlatformSingleton _mps = MediaPlatformSingleton.Instance;
      private readonly ILogger<HomeController> _logger;

      public VideoController(ILogger<HomeController> logger)
      {
         _logger = logger;
      }

      [HttpGet("{username}")]
      public List<Video> GetVideosFromUsername(string username)
      {
         if (ModelState.IsValid)
         {
            return _mps.Get<Video>().ToList();
         }
         return null;
      }
   }
}