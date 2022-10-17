using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ice_Shapers.Data;
using Ice_Shapers.Models;

namespace Ice_Shapers.Controllers
{
    public class IceController : Controller
    {
        private readonly Ice_ShapersContext _context;

        public IceController(Ice_ShapersContext context)
        {
            _context = context;
        }

        // GET: Ice
        public async Task<IActionResult> Index()
        {
           
            return View(await _context.Ice.ToListAsync());
        }

        // GET: Ice/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ice = await _context.Ice
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ice == null)
            {
                return NotFound();
            }

            return View(ice);
        }

        // GET: Ice/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ice/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price")] Ice ice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ice);
        }

        // GET: Ice/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ice = await _context.Ice.FindAsync(id);
            if (ice == null)
            {
                return NotFound();
            }
            return View(ice);
        }

        // POST: Ice/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price")] Ice ice)
        {
            if (id != ice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IceExists(ice.Id))
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
            return View(ice);
        }

        // GET: Ice/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ice = await _context.Ice
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ice == null)
            {
                return NotFound();
            }

            return View(ice);
        }

        // POST: Ice/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ice = await _context.Ice.FindAsync(id);
            _context.Ice.Remove(ice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IceExists(int id)
        {
            return _context.Ice.Any(e => e.Id == id);
        }
    }
}
