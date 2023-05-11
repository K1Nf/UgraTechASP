using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UgraTech.Context;
using UgraTech.Models;

namespace UgraTech.Controllers
{
    public class AppealsController : Controller
    {
        private readonly AppealsDbContext _context;

        public AppealsController(AppealsDbContext context)
        {
            _context = context;
        }

        // GET: Appeals
        public async Task<IActionResult> Index()
        {
            return _context.Appeals != null ?
                        View(await _context.Appeals.ToListAsync()) :
                        Problem("Entity set 'AppealsDbContext.Appeals'  is null.");
        }

        // GET: Appeals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Appeals == null)
            {
                return NotFound();
            }

            var appeals = await _context.Appeals
                .FirstOrDefaultAsync(m => m.Appeal_ID == id);
            if (appeals == null)
            {
                return NotFound();
            }

            return View(appeals);
        }

        // GET: Appeals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Appeals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Appeal_ID,Name,Email,Phone_Number,Message,Status")] Appeals appeals)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appeals);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appeals);
        }

        // GET: Appeals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Appeals == null)
            {
                return NotFound();
            }

            var appeals = await _context.Appeals.FindAsync(id);
            if (appeals == null)
            {
                return NotFound();
            }
            return View(appeals);
        }

        // POST: Appeals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Appeal_ID,Name,Email,Phone_Number,Message,Status")] Appeals appeals)
        {
            if (id != appeals.Appeal_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appeals);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppealsExists(appeals.Appeal_ID))
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
            return View(appeals);
        }

        // GET: Appeals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Appeals == null)
            {
                return NotFound();
            }

            var appeals = await _context.Appeals
                .FirstOrDefaultAsync(m => m.Appeal_ID == id);
            if (appeals == null)
            {
                return NotFound();
            }

            return View(appeals);
        }

        // POST: Appeals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Appeals == null)
            {
                return Problem("Entity set 'AppealsDbContext.Appeals'  is null.");
            }
            var appeals = await _context.Appeals.FindAsync(id);
            if (appeals != null)
            {
                _context.Appeals.Remove(appeals);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppealsExists(int id)
        {
            return (_context.Appeals?.Any(e => e.Appeal_ID == id)).GetValueOrDefault();
        }
    }
}
