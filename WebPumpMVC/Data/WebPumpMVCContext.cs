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
        public WebPumpMVCContext (DbContextOptions<WebPumpMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebPumpMVC.Models.Pump> Pump { get; set; } = default!;
    }
}
