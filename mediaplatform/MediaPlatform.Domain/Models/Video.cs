using System;

namespace MediaPlatform.Domain.Models
{
  public class Video
  {
  public long ID {get;set;}
  public string Title {get;set;}
  public long Duration {get;set;}
  public string UploadedBy {get;set;}

  public Video()
  {
    ID = DateTime.Now.Ticks;
  }

  }
}