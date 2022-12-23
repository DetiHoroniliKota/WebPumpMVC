using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPumpMVC.Data;
using WebPumpMVC.Models;

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
        public async Task<IActionResult> Index()
        {
              return View(await _context.Pump.ToListAsync());
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
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,H,Q,Price")] Pump pump)
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,H,Q,Price")] Pump pump)
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
