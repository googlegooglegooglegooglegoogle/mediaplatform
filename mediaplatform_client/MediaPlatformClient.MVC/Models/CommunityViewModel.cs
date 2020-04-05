using System;

namespace MediaPlatform.MVC.Models
{
   public class CommunityViewModel
   {
    public long ID {get;set;}
    public List<Video> Videos {get;set;}
    public string Name {get;set;}

    public CommunityViewModel() {}
   }
}
