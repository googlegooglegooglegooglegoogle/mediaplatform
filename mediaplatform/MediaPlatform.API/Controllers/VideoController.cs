using System.Collections.Generic;
using MediaPlatform.Domain.Models;
using MediaPlatform.Storing.Repositories;
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
    private MediaPlatformSingleton _mps = MediaPlatformSingleton.Instance;

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