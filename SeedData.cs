using System;
using System.Collections.Generic;
using Leo.Test.AutoRT.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Leo.Test.AutoRT
{
    public static class SeedData
    {
        public static IHost EnsureSeedDataForAutoRT(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var applicationDbContext = scope.ServiceProvider.GetService<ApplicationDbContext>();

                applicationDbContext.Database.EnsureDeletedAsync();
                applicationDbContext.Database.MigrateAsync();
                applicationDbContext.Database.EnsureCreatedAsync();

                var screens = new List<Screen>(){
                    new Screen { Category= "Others", ScreenName="EP_LOGIN", ScreenJpName="ログイン_EP"},
                    new Screen { Category= "Eface_Core", ScreenName="EC_CHANGE_ACTOR_MF", ScreenJpName= "担当者変更_MainFrame"},
                    new Screen { Category= "Create_Quick", ScreenName="EP_CREATE_APP_QUICK", ScreenJpName= "クイック申込"}
                };

                applicationDbContext.Screens.AddRangeAsync(screens);

                applicationDbContext.SaveChangesAsync();
                Console.WriteLine("Screens added");
            }
            return host;
        }
    }
}