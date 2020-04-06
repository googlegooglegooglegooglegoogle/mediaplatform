using System.Collections.Generic;
using MediaPlatform.Domain.Models;
using MediaPlatform.Storing.Repositories;
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

    public MediaPlatformRepository _mpr;
    private MediaPlatformSingleton _mps;

    public CommunityController(MediaPlatformRepository repo)
    {
        _mpr = repo;
        _mps = new MediaPlatformSingleton(_mpr);
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