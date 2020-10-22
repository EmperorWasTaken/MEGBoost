using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MEG_Boosting_Site.Data;
using MEG_Boosting_Site.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MEG_Boosting_Site
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var services = host.Services.CreateScope())
            {
                var db = services.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                var um = services.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var rm = services.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                
                ApplicationDbInitializer.Initialize(db, um, rm);
            }
            
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
