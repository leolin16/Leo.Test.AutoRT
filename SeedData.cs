using System;
using System.Collections.Generic;
using System.Linq;
using Leo.Test.AutoRT.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Leo.Test.AutoRT
{
    public static class SeedData
    {
        // for dotnet core 3.0 should be IHost rather than IWebHost
        public static IWebHost EnsureSeedDataForAutoRT(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var applicationDbContext = scope.ServiceProvider.GetService<ApplicationDbContext>();

                // applicationDbContext.Database.EnsureDeletedAsync();
                applicationDbContext.Database.MigrateAsync();
                // applicationDbContext.Database.EnsureCreatedAsync();

				if (applicationDbContext.Screens.Any())
                {
					Console.WriteLine("Screens already exist");
                }
                else
                {

                    var screens = new List<Screen>(){
                        new Screen { Category= "Others", ScreenName="EP_LOGIN", ScreenJpName="ログイン_EP"},
                        new Screen { Category= "Eface_Core", ScreenName="EC_CHANGE_ACTOR_MF", ScreenJpName= "担当者変更_MainFrame"},
                        new Screen { Category= "Create_Quick", ScreenName="EP_CREATE_APP_QUICK", ScreenJpName= "クイック申込"}
                    };

                    applicationDbContext.Screens.AddRangeAsync(screens);

                    applicationDbContext.SaveChangesAsync();
                    Console.WriteLine("Screens added");
                }

            }
            Console.WriteLine("before returning host");
            return host;
        }
    }
}