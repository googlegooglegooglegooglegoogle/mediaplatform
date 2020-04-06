using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediaPlatform.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class VideoController : ControllerBase
  {
    private readonly ILogger<VideoController> _logger;

    public VideoController(ILogger<VideoController> logger)
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