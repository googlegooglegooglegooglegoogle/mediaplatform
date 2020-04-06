using System;
using Microsoft.EntityFrameworkCore;
using MediaPlatform.Domain.Models;

namespace MediaPlatform.Storing.Databases
{
  public class MediaPlatformDbContext : DbContext
  {
    public DbSet<Community> Community {get;set;}
    public DbSet<User> User {get;set;}
    public DbSet<Video> Video {get;set;}
    public static MediaPlatformDbContext _mediaplatformdb;

    public static MediaPlatformDbContext Instance
    {
      get
      {
        if (_mediaplatformdb == null)
          _mediaplatformdb = new MediaPlatformDbContext();
        return _mediaplatformdb;
      }
    }

    public MediaPlatformDbContext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder buidler)
    {
      buidler.UseSqlServer("server=localhost;database=mediaplatformdb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Community>().HasKey(c => c.ID);
      builder.Entity<User>().HasKey(u => u.ID);
      builder.Entity<Video>().HasKey(v => v.ID);

      builder.Entity<Community>(b =>
      {
        b.Property(c => c.ID).ValueGeneratedNever();
      });

      builder.Entity<User>(b =>
      {
        b.Property(u => u.ID).ValueGeneratedNever();
      });

      builder.Entity<Video>(b =>
      {
        b.Property(v => v.ID).ValueGeneratedNever();
      });

      builder.Entity<User>().HasMany(u => u.Videos);
      builder.Entity<Community>().HasMany(v => v.Videos);
      //builder.Entity<Video>().HasOne(c => c.UploadedBy);

      builder.Entity<User>().HasData(new User[]
      {
        new User() {ID = DateTime.Now.Ticks, Name = "Demi Demi", Username = "demi", Password = "12345"},
        new User() {ID = DateTime.Now.Ticks, Name = "Jesus", Username = "jesus", Password = "Password12345"},
        new User() {ID = DateTime.Now.Ticks, Name = "George", Username = "george", Password = "password"},
        new User() {ID = DateTime.Now.Ticks, Name = "Jeremy", Username = "jeremy", Password = "12345"}
      });

      builder.Entity<Video>().HasData(new Video[]
      {
        new Video() {ID = DateTime.Now.Ticks, Title = "Tough Time Never Last, Only Tough People Last", Duration = 31, UploadedBy = "Demi Demi"},
        new Video() {ID = DateTime.Now.Ticks, Title = "Birds are not real", Duration = 500, UploadedBy = "George"},
      });

      builder.Entity<Community>().HasData(new Community[]
      {
        new Community() {ID = DateTime.Now.Ticks, Name = "Random Community"}
      });
    }
  }
    
}