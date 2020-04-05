using System;
using System.Collections.Generic;

namespace MediaPlatform.Domain.Models
{
  public class Community
  {
    public long ID {get;set;}
    public List<Video> Videos {get;set;}
    public string Name {get;set;}

    public Community()
    {
      ID = DateTime.Now.Ticks;
    }
  }
}