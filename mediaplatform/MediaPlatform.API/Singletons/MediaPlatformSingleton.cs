using System.Collections.Generic;
using System.Linq;
using MediaPlatform.Domain.Models;
using MediaPlatform.Storing.Databases;
using MediaPlatform.Storing.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MediaPlatform.API.Controllers
{
  public class MediaPlatformSingleton
  {
    //private static MediaPlatformRepository _mpr;
    private MediaPlatformRepository _mpr;

    public MediaPlatformSingleton(MediaPlatformRepository mpr)
    {
      this._mpr = mpr;
    }

    public bool CheckLogin(string username, string password)
    {
        return _mpr.Get<User>().SingleOrDefault(u => u.Username == username && u.Password == password) != null;
    }

    public Video VideoByName(string name)
    {
      return _mpr.Get<Video>().SingleOrDefault(v => v.Title == name);
    }

    public List<Community> ListOfCommunities()
    {
      return _mpr.Get<Community>().ToList();
    }

    public List<Video> VideoFromCommunity(string community_name)
    {
      MediaPlatformDbContext db = MediaPlatformRepository.GetDbContext();
      Community com = db.Set<Community>().Include(c => c.Videos).SingleOrDefault(c => c.Name == community_name);
      return com.Videos;
    }
  }
}