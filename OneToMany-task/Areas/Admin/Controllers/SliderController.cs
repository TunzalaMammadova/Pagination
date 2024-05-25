using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToMany_task.Data;
using OneToMany_task.Helpers.Extensions;
using OneToMany_task.Models;
using OneToMany_task.ViewModels.Categories;
using OneToMany_task.ViewModels.Sliders;

namespace OneToMany_task.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class SliderController : Controller
	{
		private readonly AppDbContext _context;
		private readonly IWebHostEnvironment _env;

		public SliderController(AppDbContext context,
			                    IWebHostEnvironment env)
		{
			_context = context;
			_env = env;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			List<Slider> sliders = await _context.Sliders.ToListAsync();

			List<SliderVM> result = sliders.Select(m => new SliderVM { Id = m.Id, Image = m.Image }).ToList();

			
            return View(result);
		}


		[HttpGet]
        public IActionResult Create()
        {
			return View();
        }


		[HttpPost]
		[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderCreateVM request)
        {
			if (!ModelState.IsValid) return View();

			foreach (var item in request.Images)
			{
                if (!item.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Images", "File must be only image format");
                    return View();
                }

                if (!item.CheckFileSize(200))
                {
                    ModelState.AddModelError("Images", "Image size must be max 200kb");
                }
            }

			foreach (var item in request.Images)
			{
                string fileName = Guid.NewGuid().ToString() + "-" + item.FileName;

                string path = Path.Combine(_env.WebRootPath, "img", fileName);
                ViewBag.fileName = path;

                await item.SavFileToLocalAsync(path);

                await _context.Sliders.AddAsync(new Slider { Image = fileName });

                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Delete(int? id)
		{
			if (id is null) return BadRequest();

			var slider = await _context.Sliders.FirstOrDefaultAsync(m => m.Id == id);

			if (slider is null) return NotFound();

			string path = Path.Combine(_env.WebRootPath, "img", slider.Image);

			path.DeleteFileFromToLocal();

			_context.Sliders.Remove(slider);

			await _context.SaveChangesAsync();

			return RedirectToAction(nameof(Index));

        }


		[HttpGet]
		public async Task<IActionResult> Edit(int? id)
		{
            if (id is null) return BadRequest();

            var slider = await _context.Sliders.FirstOrDefaultAsync(m => m.Id == id);

            if (slider is null) return NotFound();

			return View(new SliderEditVm { Image = slider.Image });
        }


        [HttpPost]
		[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,SliderEditVm request)
        {
            if (id is null) return BadRequest();

            var slider = await _context.Sliders.FirstOrDefaultAsync(m => m.Id == id);

            if (slider is null) return NotFound();

			if (request.NewImage is null) return RedirectToAction(nameof(Index));

            if (request.NewImage.CheckFileType("image/"))
            {
                ModelState.AddModelError("NewImage", "File must be only image format");
                return View(request);
            }

            if (request.NewImage.CheckFileSize(200))
            {
                ModelState.AddModelError("NewImage", "Image size must be max 200kb");
                request.Image = slider.Image;
                return View(request);
            }

            string oldPath = Path.Combine(_env.WebRootPath, "img", slider.Image);

            oldPath.DeleteFileFromToLocal();

            string fileName = Guid.NewGuid().ToString() + "-" + request.NewImage.FileName;

            string newPath = Path.Combine(_env.WebRootPath, "img", fileName);

            request.NewImage.SavFileToLocalAsync(newPath);

            slider.Image = fileName;

            await _context.SaveChangesAsync();

            return View(new SliderEditVm { Image = slider.Image });
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var slider = await _context.Sliders.FirstOrDefaultAsync(m => m.Id == id);

            if (slider is null) return NotFound();

            return View(new SliderDetailVM { Image = slider.Image });
        }
    }
}

