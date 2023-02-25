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

            var ropes = from m in _context.Rope
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                pumps = pumps.Where(s => s.Title == searchString);
            }

            Pump pump = (Pump)pumps;


            if (pump.H >= 1 && pump.H <= 60 && pump.Typ == "downhole")
            {
                ropes = ropes.Where(s => s.Diameter == 3);
            }

            Rope rope = (Rope)ropes;

            var selectionEquip = new SelectiomOfEquipment
            {
                Ropes = rope,
                Pumps = (List<Pump>)pumps.Where(s => s.Title == searchString)

            };
            return View(selectionEquip);
        }

    }
          
}

