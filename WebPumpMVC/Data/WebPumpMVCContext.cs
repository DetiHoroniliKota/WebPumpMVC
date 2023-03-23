using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebPumpMVC.Models;

namespace WebPumpMVC.Data
{
    public class WebPumpMVCContext : DbContext
    {
        public WebPumpMVCContext()
        {
        }

        public WebPumpMVCContext (DbContextOptions<WebPumpMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebPumpMVC.Models.Pump> Pump { get; set; } = default!;
        public DbSet<WebPumpMVC.Models.Rope> Rope { get; set; } = default!;
        public DbSet<WebPumpMVC.Models.Login> Login { get; set; } = default!;
        public DbSet<WebPumpMVC.Models.HydraulicAccumulator> HydraulicAccumulator { get; set; } = default!;
        public DbSet<WebPumpMVC.Models.Clamp> Clamp { get; set; } = default!;
        public DbSet<WebPumpMVC.Models.Pipe> Pipe { get; set; } = default!;
        public DbSet<WebPumpMVC.Models.Cap> Cap { get; set; } = default!;
        public DbSet<WebPumpMVC.Models.UnderwaterСable> UnderwaterСable { get; set; } = default!;
        public DbSet<WebPumpMVC.Models.Automation> Automation { get; set; } = default!;
        public DbSet<WebPumpMVC.Models.Equipment> Equipment { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pump>().ToTable("Pump");
            modelBuilder.Entity<Rope>().ToTable("Rope");
            modelBuilder.Entity<HydraulicAccumulator>().ToTable("HydraulicAccumulator");
            modelBuilder.Entity<Clamp>().ToTable("Clamp");
            modelBuilder.Entity<Pipe>().ToTable("Pipe");
            modelBuilder.Entity<Cap>().ToTable("Cap");
            modelBuilder.Entity<UnderwaterСable>().ToTable("UnderwaterСable");
            modelBuilder.Entity<Automation>().ToTable("Automation");
            modelBuilder.Entity<Equipment>().ToTable("Equipment");
        }

    }
}
