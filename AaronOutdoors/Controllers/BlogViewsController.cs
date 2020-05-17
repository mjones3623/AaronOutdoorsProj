using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AaronOutdoors.Data;
using AaronOutdoors.Models;

namespace AaronOutdoors.Controllers
{
    public class BlogViewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogViewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BlogViews
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogViews.ToListAsync());
        }

        // GET: BlogViews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogView = await _context.BlogViews
                .FirstOrDefaultAsync(m => m.BlogViewId == id);
            if (blogView == null)
            {
                return NotFound();
            }

            return View(blogView);
        }

        // GET: BlogViews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BlogViews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BlogViewId")] BlogView blogView)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blogView);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blogView);
        }

        // GET: BlogViews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogView = await _context.BlogViews.FindAsync(id);
            if (blogView == null)
            {
                return NotFound();
            }
            return View(blogView);
        }

        // POST: BlogViews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BlogViewId")] BlogView blogView)
        {
            if (id != blogView.BlogViewId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogView);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogViewExists(blogView.BlogViewId))
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
            return View(blogView);
        }

        // GET: BlogViews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogView = await _context.BlogViews
                .FirstOrDefaultAsync(m => m.BlogViewId == id);
            if (blogView == null)
            {
                return NotFound();
            }

            return View(blogView);
        }

        // POST: BlogViews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogView = await _context.BlogViews.FindAsync(id);
            _context.BlogViews.Remove(blogView);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogViewExists(int id)
        {
            return _context.BlogViews.Any(e => e.BlogViewId == id);
        }
    }
}
