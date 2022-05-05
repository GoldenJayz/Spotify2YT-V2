using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using SpotifyAPI.Web;
using System;
using System.Threading.Tasks;

namespace Spotify2YT
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
