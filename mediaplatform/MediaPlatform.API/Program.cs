using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlatform.Storing.Databases;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MediaPlatform.API.Controllers;

namespace MediaPlatform.API
{
   public class Program
   {
      public static void Main(string[] args)
      {
         LoadDatabase(CreateHostBuilder(args).Build()).Run();
      }

      public static IHostBuilder CreateHostBuilder(string[] args) =>
          Host.CreateDefaultBuilder(args)
              .ConfigureWebHostDefaults(webBuilder =>
              {
                 webBuilder.UseStartup<Startup>();
              });
      

      private static IHost LoadDatabase(IHost host)
      {
         var dbContext = host.Services.GetRequiredService<MediaPlatformDbContext>();

         dbContext.Database.EnsureCreated();
         
         MediaPlatformSingleton.Instance.SetDbContext(dbContext);

         return host;
      }

   }
}
