using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPumpMVC.Data;
using WebPumpMVC.Models;
using System.Text.Encodings.Web;



namespace WebPumpMVC.Controllers
{


    public class EquipmentController : Controller
    {
        private readonly WebPumpMVCContext _context;

        public EquipmentController(WebPumpMVCContext context)
        {
            _context = context;
        }

       /* public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Pump == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }


            var pumps = from m in _context.Pump
                        select m;

            var ropes = from m in _context.Rope
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                pumps = pumps.Where(s => s.Title!.Contains(searchString));
                var selection = _context.Select(s => new SelectiomOfEquipment 
                {Ropes = s._context.Ropes, Pumps = s._context.Pumps }); 
            }


            SelectiomOfEquipment EqipmentModel = new SelectiomOfEquipment
            {
                Pumps = (List<Pump>)pumps,
                Ropes = (List<Rope>)ropes

            };
            return View(EqipmentModel);
        }*/
        public IActionResult Some(string searchString)
        {
            var pump = _context.Pump.Where(s => s.Title!.Contains(searchString));
            ViewData["PumpTitle"] = pump;
            
            Pump pumpH = (Pump)pump;
            
            if (pumpH.H >= 0 && pumpH.H <= 80)
            {
                ViewData["RopeTitle"] = _context.Rope.Where(s => s.Diameter == 3);
            }
            else 
            {
                ViewData["RopeTitle"] = _context.Rope.Where(s => s.Diameter == 4);
            }
            


            return View();
        }

    }
    
}

