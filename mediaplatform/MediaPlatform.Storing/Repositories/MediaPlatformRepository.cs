using System.Collections.Generic;
using System.Linq;
using MediaPlatform.Domain.Interfaces;
using MediaPlatform.Storing.Databases;

namespace MediaPlatform.Storing.Repositories
{
   public class MediaPlatformRepository
   {
      private static MediaPlatformDbContext _db;

      public MediaPlatformRepository(MediaPlatformDbContext dbContext)
      {
         _db = dbContext;
      }

      public IEnumerable<T> Get<T>() where T : class
      {
         return _db.Set<T>();
      }

      public T Get<T>(long id) where T : class, IDbItem
      {
         return _db.Set<T>().SingleOrDefault(t => t.ID == id);
      }

      public bool Post<T>(T item) where T : class
      {
         _db.Set<T>().Add(item);
         return _db.SaveChanges() == 1;
      }

      public bool Put<T>(T item) where T : class, IDbItem
      {
         var i = Get<T>(item.ID);

         i = item;

         return _db.SaveChanges() == 1;
      }
   }
}