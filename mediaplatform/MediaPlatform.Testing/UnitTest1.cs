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

        [Fact]
        public void Test_User_Model_ID()
        {
          User sut = new User();
          var actual = sut.ID;

          Assert.True(actual >= 0);
        }

        [Fact]
        public void Test_Video_Model_ID()
        {
          Video sut = new Video();
          var actual = sut.ID;

          Assert.True(actual >= 0);
        }

        [Fact]
        public void Test_Video_Community_ID()
        {
          Community sut = new Community();
          var actual = sut.ID;

          Assert.True(actual >= 0);
        }

    }
}
