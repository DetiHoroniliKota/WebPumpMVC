using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebPumpMVC.Data;
using System;
using System.Linq;
using WebPumpMVC.Models;

namespace WebPumpMVC.SeedData;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WebPumpMVCContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<WebPumpMVCContext>>()))
        {
            // Look for any movies.
            if (context.Pump.Any())
            {
                return;   // DB has been seeded
            }
            context.Pump.AddRange(
                new Pump
                {
                    Title = "SQЕ 3-50",
                    ReleaseDate = DateTime.Parse("2000-2-12"),
                    H = 50,
                    Q = 3,
                    Price = 50000,
                    Typ = "downhole"
                },
                new Pump
                {
                    Title = "SQЕ 3-60",
                    ReleaseDate = DateTime.Parse("2000-2-12"),
                    H = 60,
                    Q = 3,
                    Price = 60000,
                    Typ = "downhole"
                },
                new Pump
                {
                    Title = "SQЕ 3-70",
                    ReleaseDate = DateTime.Parse("2000-2-12"),
                    H = 70,
                    Q = 3,
                    Price = 70000,
                    Typ = "downhole"
                },
                new Pump
                {
                    Title = "SQЕ 3-80",
                    ReleaseDate = DateTime.Parse("2000-2-12"),
                    H = 80,
                    Q = 3,
                    Price = 80000,
                    Typ = "downhole"
                }
            );
            context.SaveChanges();
        }
    }
}


