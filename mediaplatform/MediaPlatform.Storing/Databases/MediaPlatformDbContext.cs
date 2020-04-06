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

    public MediaPlatformDbContext(DbContextOptions options) : base(options)
    {

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
      builder.Entity<Video>().HasOne(c => c.Community);
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
        new Video() {ID = DateTime.Now.Ticks, Title = "Tough Time Never Last, Only Tough People Last", Duration = 31, UploadedBy = "Demi Demi", URL = "https://www.youtube.com/embed/1puR8jGK03A"},
        new Video() {ID = DateTime.Now.Ticks, Title = "Birds are not real", Duration = 247, UploadedBy = "George", URL = "https://www.youtube.com/embed/l30_APBNPXg"},
        new Video() {ID = DateTime.Now.Ticks, Title = "Americans brace for possible approach of coronavirus peak", Duration = 552, UploadedBy = "Jeremy", URL = "https://www.youtube.com/embed/MwaK-SmcIx0"},
        new Video() {ID = DateTime.Now.Ticks, Title = "Watch Elon Musk announce the Tesla Cybertruck in 14 minutes", Duration = 1343, UploadedBy = "Jesus", URL = "https://www.youtube.com/embed/464puoD09dM"},
        new Video() {ID = DateTime.Now.Ticks, Title = "Rick Astley - Never Gonna Give You up (video)", Duration = 332, UploadedBy = "George", URL = "https://www.youtube.com/embed/dQw4w9WgXcQ"},
        new Video() {ID = DateTime.Now.Ticks, Title = "The Kooks - Naive", Duration = 322, UploadedBy = " George", URL = "https://www.youtube.com/embed/jkaMiaRLgvY"},
        new Video() {ID = DateTime.Now.Ticks, Title = "Gladiator Opening Scene(Part 1)", Duration = 535, UploadedBy = "Jeremy", URL = "https://www.youtube.com/embed/yXiSp9aJYN4"},
        new Video() {ID = DateTime.Now.Ticks, Title = "Harry Potter and the Deathly Hallows part 2 - Snape's memories part 2 (HD)", Duration = 428, UploadedBy = "Jesus", URL = "https://www.youtube.com/embed/iqyf-kJWwIg"},
        new Video() {ID = DateTime.Now.Ticks, Title = "Shaq Tries to Not Make a Face While Eating Spicy Wings | Hot Ones", Duration = 3109, UploadedBy = "George", URL = "https://www.youtube.com/embed/_sZH-psg9yE"},
        new Video() {ID = DateTime.Now.Ticks, Title = "Engine Placement EXPLAINED", Duration = 1336, UploadedBy = "Jesus", URL = "https://www.youtube.com/embed/SiOSbHo2dvk"},
      });

      builder.Entity<Community>().HasData(new Community[]
      {
        new Community() {ID = DateTime.Now.Ticks, Name = "Random Community"}
      });
    }
  }
    
}