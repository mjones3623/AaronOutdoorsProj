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
    public class BlogCommentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogCommentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BlogComments
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogComments.ToListAsync());
        }

        // GET: BlogComments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogComment = await _context.BlogComments
                .FirstOrDefaultAsync(m => m.BlogCommentId == id);
            if (blogComment == null)
            {
                return NotFound();
            }

            return View(blogComment);
        }

        // GET: BlogComments/Create
        public IActionResult Create(int? id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var siteUser = _context.SiteUsers.Where(i => i.IdentityUserId == userId).FirstOrDefault();
            var blogPost = _context.BlogPosts.Where(m => m.BlogPostId == id).FirstOrDefault();
            var commentsThisPost = _context.BlogComments.Where(c => blogPost.BlogPostId == c.CommentBlogPostId).ToList();
            ViewBag.BlogPost = blogPost;
            ViewBag.CommentsThisPost = commentsThisPost;
            ViewBag.SiteUser = siteUser;

            return View();
        }

        // POST: BlogComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BlogCommentId,CommentBlogPostId,BlogCommentSiteUserId,BlogCommentText,BlogCommentDateTime")] BlogComment blogComment)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var siteUser = _context.SiteUsers.Where(i => i.IdentityUserId == userId).FirstOrDefault();
                var commentBlogPost = _context.BlogPosts.Where(b => b.BlogPostId == blogComment.CommentBlogPostId).FirstOrDefault();
                DateTime dateTimeNow = DateTime.Now;
                
                blogComment.BlogCommentDateTime = dateTimeNow;
                blogComment.BlogCommentSiteUserId = siteUser.SiteUserId;
                blogComment.CommentBlogPostId = commentBlogPost.BlogPostId;

                _context.Add(blogComment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(blogComment);
        }

        // GET: BlogComments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogComment = await _context.BlogComments.FindAsync(id);
            if (blogComment == null)
            {
                return NotFound();
            }
            return View(blogComment);
        }

        // POST: BlogComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BlogCommentId,BlogCommentSiteUserId,BlogCommentText,BlogCommentDateTime")] BlogComment blogComment)
        {
            if (id != blogComment.BlogCommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogComment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogCommentExists(blogComment.BlogCommentId))
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
            return View(blogComment);
        }

        // GET: BlogComments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogComment = await _context.BlogComments
                .FirstOrDefaultAsync(m => m.BlogCommentId == id);
            if (blogComment == null)
            {
                return NotFound();
            }

            return View(blogComment);
        }

        // POST: BlogComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogComment = await _context.BlogComments.FindAsync(id);
            _context.BlogComments.Remove(blogComment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogCommentExists(int id)
        {
            return _context.BlogComments.Any(e => e.BlogCommentId == id);
        }
    }
}
