using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using slivrr.Areas.Identity.Data;

[assembly: HostingStartup(typeof(slivrr.Areas.Identity.IdentityHostingStartup))]
namespace slivrr.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<slivrrIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("slivrrIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<slivrrIdentityDbContext>();

                services.BuildServiceProvider().GetService<slivrrIdentityDbContext>()
                    .Database.Migrate();
            });
        }
    }
}