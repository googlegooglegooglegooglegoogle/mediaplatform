using System;
using System.Collections.Generic;

namespace MediaPlatform.Domain.Models
{
  public class User 
  {
    public long ID {get;set;}
    public string Name {get;set;}
    public string Username {get;set;}
    public string Password {get;set;}
    public List<Video> Videos{get;set;}
    public List<Community> Communities{get;set;}

    public User()
    {
      ID = DateTime.Now.Ticks;
    }
  }
}