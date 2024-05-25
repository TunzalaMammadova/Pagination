using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToMany_task.Data;
using OneToMany_task.Models;

namespace OneToMany_task.Controllers
{
	public class BlogController:Controller
	{
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            int count = await _context.Blogs.CountAsync();
            ViewBag.count = count;
            return View(await _context.Blogs.Take(3).ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult>ShowMore(int skip)
        {
            List<Blog> blogs = await _context.Blogs.Skip(skip).Take(3).ToListAsync();

            return PartialView("_BlogsPartial", blogs);
        }
        
    }
}

