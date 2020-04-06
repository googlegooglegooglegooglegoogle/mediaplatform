using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediaPlatform.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CommunityController : ControllerBase
  {
    private readonly ILogger<CommunityController> _logger;

    public CommunityController(ILogger<CommunityController> logger)
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