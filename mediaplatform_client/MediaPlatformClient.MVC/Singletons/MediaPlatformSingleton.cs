using System.Net.Http;

namespace MediaPlatformClient.MVC.Singletons
{
    class MediaPlatformSingleton
    {
        private static readonly MediaPlatformSingleton _mps = new MediaPlatformSingleton();
        public string SessionUsername {get; set;} = "";

         private MediaPlatformSingleton()
         {
             
         }

        public static MediaPlatformSingleton Instance 
        {
           get
           {
              return _mps;
           }
        }

        public HttpClient Client { get; } = new HttpClient();

        
        
    }
}