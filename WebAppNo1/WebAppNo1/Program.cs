using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebAppNo1.Models;

namespace WebAppNo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*CreateHostBuilder(args).Build().Run();*/
            var h = CreateHostBuilder(args).Build();
            using (var scope = h.Services.CreateScope()) {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<AppDbContext>();
                    DbUtil.LoadTableIndivial(context);
                    DbUtil.LoadTableConption(context);
                }
                catch (Exception)
                {

                }
            }
            h.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
