using System;
using System.Collections.Generic;
using MediaPlatform.Domain.Interfaces;

namespace MediaPlatform.Domain.Models
{
  public class Community : IDbItem
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