using System;

namespace MediaPlatform.MVC.Models
{
   public class VideoViewModel
   {
    public long ID {get;set;}
    public string Title {get;set;}
    public long Duration {get;set;}
    public string UploadedBy {get;set;}

    public VideoViewModel() {}
  }
}
