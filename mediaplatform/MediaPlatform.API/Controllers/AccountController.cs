using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlatform.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Storing.Repositories;

namespace MediaPlatform.API.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class AccountController : ControllerBase
   {

      public MediaPlatformRepository _mpr;

      public AccountController(MediaPlatformRepository repo)
      {
         _mpr = repo;
      }

      [HttpGet]
      public IEnumerable<User> Get()
      {
         return null;
      }
   }
}
