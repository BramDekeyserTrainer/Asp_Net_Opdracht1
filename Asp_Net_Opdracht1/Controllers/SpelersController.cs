using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Asp_Net_Opdracht1.Data;
using Asp_Net_Opdracht1.Models;

namespace Asp_Net_Opdracht1.Controllers
{
    public class SpelersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SpelersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Spelers
        public async Task<IActionResult> Index()
        {
              return View(await _context.Speler.ToListAsync());
        }

        // GET: Spelers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Speler == null)
            {
                return NotFound();
            }

            var speler = await _context.Speler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (speler == null)
            {
                return NotFound();
            }

            return View(speler);
        }

        // GET: Spelers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Spelers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Club_Id,Speler_Voornaam,speler_Achternaam")] Speler speler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(speler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(speler);
        }

        // GET: Spelers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Speler == null)
            {
                return NotFound();
            }

            var speler = await _context.Speler.FindAsync(id);
            if (speler == null)
            {
                return NotFound();
            }
            return View(speler);
        }

        // POST: Spelers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Club_Id,Speler_Voornaam,speler_Achternaam")] Speler speler)
        {
            if (id != speler.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(speler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpelerExists(speler.Id))
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
            return View(speler);
        }

        // GET: Spelers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Speler == null)
            {
                return NotFound();
            }

            var speler = await _context.Speler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (speler == null)
            {
                return NotFound();
            }

            return View(speler);
        }

        // POST: Spelers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Speler == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Speler'  is null.");
            }
            var speler = await _context.Speler.FindAsync(id);
            if (speler != null)
            {
                _context.Speler.Remove(speler);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpelerExists(int id)
        {
          return _context.Speler.Any(e => e.Id == id);
        }
    }
}
