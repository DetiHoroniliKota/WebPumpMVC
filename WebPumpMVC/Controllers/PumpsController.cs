using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPumpMVC.Data;
using WebPumpMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;


namespace WebPumpMVC.Controllers
{
    
    public class PumpsController : Controller
    {
        private readonly WebPumpMVCContext _context;

        public PumpsController(WebPumpMVCContext context)
        {
            _context = context;
        }

        // GET: Pumps
        //[Authorize]
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
        
        //Подбор скваженного насоса

         public async Task<IActionResult> Search (int Ha, int Hb, int Hc,  int volume )
         {

            int He = 30;// Давление на выходе 
             int pressure = Ha + Hb + Hc + He;

             if (_context.Pump == null)
             {
                 return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
             }

             var pumps = from m in _context.Pump
                         select m;
             if (pressure >= 0 & volume >=0)
             {
                 pumps = pumps.Where(s => s.Q >= volume && s.H >= pressure );
             }

            return View(await pumps.ToListAsync());
        }
        //Подбор циркуляционного насоса 
        public async Task<IActionResult> SearchCirculationPump(int S, int L)
        {
            //Расчет производительности Циркуляционного насоса
            int p = S*100/1000;// Мощность отпительной системы в ватт 
            double CoefficientOfWater = 0.86; //коэффициент теплоемкости воды
            int dT = 20;//Pазница температуры между подачей и обраткой(Дельта в градусах)
            double Q = (CoefficientOfWater * p) / dT;//Производительность насоса

            //Расчет напора Циркуляционного насоса
            double z = 2.2; //Коффициент сопротивление элементов системы
            double r = 0.015; // Сопротивление трубопровода (150 Паскалей = 0.015 на метр трубы)
            double h = z * r * L;//Требуемый напор насоса
            

            if (_context.Pump == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var pumps = from m in _context.Pump
                        select m;
            if (h >= 0 & Q >= 0)
            {
                pumps = pumps.Where(s => s.Q >= Q && s.H >= h && s.Typ == "Circulation");
            }

            return  View (await pumps.ToListAsync());
        }


        //Подбор Дренажного насоса

        public async Task<IActionResult> SearchDrainage(int Hq, int Hw, int QQ)
        {

             
            int pressure = Hq + Hw ;

            if (_context.Pump == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var pumps = from m in _context.Pump
                        select m;
            if (pressure >= 0 & QQ >= 0)
            {
                pumps = pumps.Where(s => s.Q >= QQ && s.H >= pressure && s.Typ == "drainage");
            }

            return View(await pumps.ToListAsync());
        }

        // GET: Pumps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pump == null)
            {
                return NotFound();
            }

            var pump = await _context.Pump
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pump == null)
            {
                return NotFound();
            }

            return View(pump);
        }

        // GET: Pumps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pumps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,H,Q,Price,Typ,Equipment")] Pump pump)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pump);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pump);
        }

        // GET: Pumps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pump == null)
            {
                return NotFound();
            }

            var pump = await _context.Pump.FindAsync(id);
            if (pump == null)
            {
                return NotFound();
            }
            return View(pump);
        }

        // POST: Pumps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,H,Q,Price,Typ,Equipment")] Pump pump)
        {
            if (id != pump.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pump);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PumpExists(pump.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pump);
        }

        // GET: Pumps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pump == null)
            {
                return NotFound();
            }

            var pump = await _context.Pump
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pump == null)
            {
                return NotFound();
            }

            return View(pump);
        }

        // POST: Pumps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pump == null)
            {
                return Problem("Entity set 'WebPumpMVCContext.Pump'  is null.");
            }
            var pump = await _context.Pump.FindAsync(id);
            if (pump != null)
            {
                _context.Pump.Remove(pump);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PumpExists(int id)
        {
          return _context.Pump.Any(e => e.Id == id);
        }
    }
}
