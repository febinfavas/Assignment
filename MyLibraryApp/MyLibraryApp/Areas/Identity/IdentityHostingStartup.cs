using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyLibraryApp.Areas.Identity.Data;
using MyLibraryApp.Data;

[assembly: HostingStartup(typeof(MyLibraryApp.Areas.Identity.IdentityHostingStartup))]
namespace MyLibraryApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MyLibraryAppAuthContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MyLibraryAppContextConnection")));

                services.AddDefaultIdentity<MyLibraryAppUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                    })
                    .AddEntityFrameworkStores<MyLibraryAppAuthContext>();
            });
        }
    }
}