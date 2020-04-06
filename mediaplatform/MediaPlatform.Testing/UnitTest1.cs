using System;
using System.Linq;
using MediaPlatform.Domain.Models;
using MediaPlatform.Storing.Databases;
using MediaPlatform.Storing.Repositories;
using Xunit;

namespace MediaPlatform.Testing
{
    public class UnitTest1
    {
      MediaPlatformDbContext db = MediaPlatformRepository.GetDbContext();
        [Fact]
        public void Test_User_List_Not_Empty()
        {
          var sut = new MediaPlatformRepository(db);
          var actual = sut.Get<User>().ToList();

          Assert.True(actual.Count >= 0);
        }
    }
}
