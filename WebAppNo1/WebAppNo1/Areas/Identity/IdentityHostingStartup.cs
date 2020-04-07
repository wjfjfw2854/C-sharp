using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebAppNo1.Models;

[assembly: HostingStartup(typeof(WebAppNo1.Areas.Identity.IdentityHostingStartup))]
namespace WebAppNo1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //加入以下的by wjf
                services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();
            });
        }
    }
}