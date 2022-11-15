using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DatabaseFirstAppPK.Models;

namespace DatabaseFirstAppPK.Controllers
{
    public class Car : Controller
    {
        private readonly CarDbContext _context;

        public Car(CarDbContext context)
        {
            _context = context;
        }

        // GET: Car
        public async Task<IActionResult> Index()
        {
              return View(await _context.CarTables.ToListAsync());
        }

        // GET: Car/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CarTables == null)
            {
                return NotFound();
            }

            var carTable = await _context.CarTables
                .FirstOrDefaultAsync(m => m.CarId == id);
            if (carTable == null)
            {
                return NotFound();
            }

            return View(carTable);
        }

        // GET: Car/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Car/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarId,CarBrand,CarModel,CarPrice")] CarTable carTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carTable);
        }

        // GET: Car/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CarTables == null)
            {
                return NotFound();
            }

            var carTable = await _context.CarTables.FindAsync(id);
            if (carTable == null)
            {
                return NotFound();
            }
            return View(carTable);
        }

        // POST: Car/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CarId,CarBrand,CarModel,CarPrice")] CarTable carTable)
        {
            if (id != carTable.CarId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarTableExists(carTable.CarId))
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
            return View(carTable);
        }

        // GET: Car/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CarTables == null)
            {
                return NotFound();
            }

            var carTable = await _context.CarTables
                .FirstOrDefaultAsync(m => m.CarId == id);
            if (carTable == null)
            {
                return NotFound();
            }

            return View(carTable);
        }

        // POST: Car/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CarTables == null)
            {
                return Problem("Entity set 'CarDbContext.CarTables'  is null.");
            }
            var carTable = await _context.CarTables.FindAsync(id);
            if (carTable != null)
            {
                _context.CarTables.Remove(carTable);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarTableExists(int id)
        {
          return _context.CarTables.Any(e => e.CarId == id);
        }
    }
}
