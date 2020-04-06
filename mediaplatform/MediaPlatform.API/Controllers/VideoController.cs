using System.Collections.Generic;
using MediaPlatform.Domain.Models;
using MediaPlatform.Storing.Databases;
using MediaPlatform.Storing.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediaPlatform.API.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   public class VideoController : ControllerBase
   {
      private MediaPlatformSingleton _mps = MediaPlatformSingleton.Instance;
      private readonly ILogger<HomeController> _logger;

      public VideoController(ILogger<HomeController> logger, MediaPlatformDbContext dbContext)
      {
         _mps.SetDbContext(dbContext);
         _logger = logger;
      }

      [HttpGet]
      public Video GetVideoByName(string name)
      {
         if (ModelState.IsValid)
         {
            return _mps.VideoByName(name);
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