using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AaronOutdoors.Data;
using AaronOutdoors.Models;
using System.Security.Claims;

namespace AaronOutdoors.Controllers
{
    public class SiteUsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SiteUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SiteUsers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SiteUsers.Include(s => s.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SiteUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siteUser = await _context.SiteUsers
                .Include(s => s.IdentityUser)
                .FirstOrDefaultAsync(m => m.SiteUserId == id);
            if (siteUser == null)
            {
                return NotFound();
            }

            return View(siteUser);
        }

        // GET: SiteUsers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: SiteUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SiteUserId,IdentityUserId,SiteUserFirstName,SiteUserLastName,SiteUserStreetAddress,SiteUserCity,SiteUserState,SiteUserZipCode,SiteUserPhone,image")] SiteUser siteUser)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                siteUser.IdentityUserId = userId;
                _context.Add(siteUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", siteUser.IdentityUserId);
            return View(siteUser);
        }

        // GET: SiteUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siteUser = await _context.SiteUsers.FindAsync(id);
            if (siteUser == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", siteUser.IdentityUserId);
            return View(siteUser);
        }

        // POST: SiteUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SiteUserId,IdentityUserId,SiteUserFirstName,SiteUserLastName,SiteUserStreetAddress,SiteUserCity,SiteUserState,SiteUserZipCode,SiteUserPhone,image")] SiteUser siteUser)
        {
            if (id != siteUser.SiteUserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(siteUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SiteUserExists(siteUser.SiteUserId))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", siteUser.IdentityUserId);
            return View(siteUser);
        }

        // GET: SiteUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siteUser = await _context.SiteUsers
                .Include(s => s.IdentityUser)
                .FirstOrDefaultAsync(m => m.SiteUserId == id);
            if (siteUser == null)
            {
                return NotFound();
            }

            return View(siteUser);
        }

        // POST: SiteUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var siteUser = await _context.SiteUsers.FindAsync(id);
            _context.SiteUsers.Remove(siteUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SiteUserExists(int id)
        {
            return _context.SiteUsers.Any(e => e.SiteUserId == id);
        }
    }
}
