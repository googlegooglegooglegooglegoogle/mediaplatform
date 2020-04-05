using System;

namespace MediaPlatform.MVC.Models
{
    public class UserViewModel
    {
      public long ID {get;set;}
      public string Name {get;set;}
      public string Username {get;set;}
      public string  Password {get;set;}
      public List<Video> Videos{get;set;}
      public List<Community> Communities{get;set;}

      public UserViewModel() {}
    }
}
