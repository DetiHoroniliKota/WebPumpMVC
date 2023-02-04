using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPumpMVC.Data;
using WebPumpMVC.Models;

namespace WebPumpMVC.Controllers
{
    
    
        public class EquipmentController : Controller
        {
            private readonly WebPumpMVCContext _context;

            public EquipmentController(WebPumpMVCContext context)
            {
                _context = context;
            }

        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Pump == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var pumps = from m in _context.Pump
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                pumps = pumps.Where(s => s.Title!.Contains(searchString));
            }

            return View(await pumps.ToListAsync());
        }



        public async Task<IActionResult> Equip(string np)
            {

                if (np == null || _context.Pump == null)
                {
                    return NotFound();
                }

                var pump = await _context.Pump
                    .FirstOrDefaultAsync(m => m.Title == np);
                if (pump == null)
                {
                    return NotFound();
                }


                var rope = new Rope();
                
                if (pump.H < 50)
                {
                     rope = _context.Rope.FirstOrDefault(r => r.Diameter == 3);
                }

                else if (pump.H >= 50 && pump.H >= 120 )
                {
                     rope = _context.Rope.FirstOrDefault(r => r.Diameter == 4);
                }

                else 
                {
                     rope = _context.Rope.FirstOrDefault(r => r.Diameter == 5);
                }
                
                ViewData["RopeTitle"] = rope;
               
                return View();
               
            }

        }

    
}

