using System.Linq;
using MediaPlatform.Domain.Models;
using MediaPlatform.Storing.Repositories;

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
  }
}