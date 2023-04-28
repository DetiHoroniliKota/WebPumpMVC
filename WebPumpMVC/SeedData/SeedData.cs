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
            var pumps = new Pump[]
            {
            new Pump {Title = "TF3 40",ReleaseDate = DateTime.Parse("2000-2-12"),H = 40,Q = 3,Price = 9752, Typ = "downhole"},
            new Pump {Title = "TF3-60",ReleaseDate = DateTime.Parse("2000-2-12"),H = 60,Q = 3,Price = 50000, Typ = "downhole"},
            new Pump {Title = "TF3-80",ReleaseDate = DateTime.Parse("2000-2-12"),H = 80,Q = 3,Price = 50000, Typ = "downhole"},
            new Pump {Title = "TF3-110",ReleaseDate = DateTime.Parse("2000-2-12"),H = 110,Q = 3,Price = 50000, Typ = "downhole"}
            };
            foreach (Pump p in pumps)
            {
                context.Pump.Add(p);
            }
            context.SaveChanges();


           // var hydraulicAccumulators = new HydraulicAccumulator[]
           // {
           //     new HydraulicAccumulator  {Title = "50VT", Volume = 50, Price = 4403, Typ = "vertical" },
           //     new HydraulicAccumulator  {Title = "80VT", Volume = 80, Price = 7602, Typ = "vertical" },
           //     new HydraulicAccumulator  {Title = "100VT", Volume = 100, Price = 8652, Typ = "vertical" },
           // };
           // foreach (HydraulicAccumulator h in hydraulicAccumulators)
           // {
           //     context.HydraulicAccumulator.Add(h);
           // }
           // context.SaveChanges();


           // var rope = new Rope[]
           // {
           //     new Rope  {Title = "3мм SS304,7*7ACR", Diameter = 3, Price = 55 },
           //     new Rope  {Title = "4мм SS304,7*7ACR", Diameter = 4, Price = 85 } 
           // };

           // foreach (Rope r in rope)
           // {
           //     context.Rope.Add(r);
           // }
           // context.SaveChanges();


           // var clamp = new Clamp[]
           // {
           //     new Clamp  {Title = "3мм DOUBLE SS304 ACR", Diameter = 3, Price = 57, Typ = "double" },
           //     new Clamp  {Title = "4мм DOUBLE SS304 ACR", Diameter = 4, Price = 72, Typ = "double" },
           //     new Clamp  {Title = "3мм SINGLE SS304 ACR", Diameter = 3, Price = 28, Typ = "single" },
           //     new Clamp  {Title = "4мм SINGLE SS304 ACR", Diameter = 4, Price = 40, Typ = "single" }
           // };
           // foreach (Clamp c in clamp)
           // {
           //     context.Clamp.Add(c);
           // }
           // context.SaveChanges();


           // var pipe = new Pipe[]
           // {
           //     new Pipe  {Title = "25 Х 2 ММ - АРТИКУЛ: 9500", Diameter = 25, Price = 62 },
           //     new Pipe  {Title = "32Х2,4 ММ - АРТИКУЛ: 9502", Diameter = 32, Price = 95 },
           //     new Pipe  {Title = "32Х3,0 ММ - АРТИКУЛ: 9514", Diameter = 32, Price = 106 },

           // };
           // foreach (Pipe p in pipe)
           // {
           //     context.Pipe.Add(p);
           // }
           // context.SaveChanges();


           // var cap = new Cap[]
           // {
           //     new Cap  {Title = "110-130/25  АРТИКУЛ: 6002", Price = 2400, Typ = "plastic"  },
           //     new Cap  {Title = "90-110/32    АРТИКУЛ: 6001", Price = 2300, Typ = "plastic"  },
           //     new Cap  {Title = "110-130/32  АРТИКУЛ: 6003", Price = 2400, Typ = "plastic"  },
           //     new Cap  {Title = "130-140/32  АРТИКУЛ:  6004", Price = 2500, Typ = "plastic"  },
           //     new Cap  {Title = "107-127/32 - АРТИКУЛ: 6008", Price = 5850, Typ = "castIron"  },
           //     new Cap  {Title = "127-140/32 - АРТИКУЛ: 6009", Price = 6820, Typ = "castIron"  },

           // };
           // foreach (Cap c in cap)
           // {
           //     context.Cap.Add(c);
           // }
           // context.SaveChanges();

           // var underwaterСable = new UnderwaterСable[]
           //{
           //     new UnderwaterСable  {Title = "3 Х 1,5 АРТИКУЛ: КВВ3*1,5", Section =1.5 , Price = 168   },
           //     new UnderwaterСable  {Title = "3 Х 2,5 АРТИКУЛ: КВВ3*2,5", Section =2.5 , Price = 250   }

           //};
           // foreach (UnderwaterСable u in underwaterСable)
           // {
           //     context.UnderwaterСable.Add(u);
           // }
           // context.SaveChanges();


           // var automation = new Automation[]
           // {
           //     new Automation  {Title = "РЕЛЕ - давления BELAMOS - АРТИКУЛ: PS-02C", Price = 558 , Typ = "mechanics"   },
           //     new Automation  {Title = "BELAMOS BRIO-2015 - АРТИКУЛ: Brio-2015", Price = 4019, Typ = "automation"   }

           // };
           // foreach (Automation a in automation)
           // {
           //     context.Automation.Add(a);
           // }
           // context.SaveChanges();


           // var equipment = new Equipment[]
           // {
           //     new Equipment  { PumpsId,RopeId,HydraulicAccumulatorId,ClampId,PipeId,CapId,UnderwaterСableId,AutomationId }
                

           // };
           // foreach (Automation a in automation)
           // {
           //     context.Automation.Add(a);
           // }
           // context.SaveChanges();



            /* context.Pump.AddRange(
                 new Pump
                 {
                     Title = "SQЕ 3-50",
                     ReleaseDate = DateTime.Parse("2000-2-12"),
                     H = 50,
                     Q = 3,
                     Price = 50000,
                     Typ = "downhole",
                     Equipments = ""
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
             context.SaveChanges();*/
        }
    }
}


