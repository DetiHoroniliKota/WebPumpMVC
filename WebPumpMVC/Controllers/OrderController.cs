using Microsoft.AspNetCore.Mvc;
using WebPumpMVC.Data;
using WebPumpMVC.Models;
using System;

namespace WebPumpMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly WebPumpMVCContext _context;

        public OrderController(WebPumpMVCContext context)
        {
            _context = context;

        }

        public IActionResult index(string serchString)
        {
            if(_context.Pump == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var pump = from m in _context.Pump
                       select m;
            
            if(!string.IsNullOrEmpty(serchString))
            {
                pump = pump.Where(s => s.Title!.Contains(serchString));
            }

            return View();
        }
    }
}
