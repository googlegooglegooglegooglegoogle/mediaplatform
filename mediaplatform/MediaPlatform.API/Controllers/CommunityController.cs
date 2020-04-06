using System.Collections.Generic;
using MediaPlatform.Domain.Models;
using MediaPlatform.Storing.Databases;
using MediaPlatform.Storing.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediaPlatform.API.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class CommunityController : ControllerBase
   {

      private MediaPlatformSingleton _mps = MediaPlatformSingleton.Instance;
      private readonly ILogger<HomeController> _logger;

      public CommunityController(ILogger<HomeController> logger, MediaPlatformDbContext dbContext)
      {
         _mps.SetDbContext(dbContext);
         _logger = logger;
      }

      [HttpGet]
      public List<Community> GetCommunityList()
      {
         if (ModelState.IsValid)
         {
            return _mps.ListOfCommunities();
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