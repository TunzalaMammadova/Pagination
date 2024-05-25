using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToMany_task.Data;
using OneToMany_task.Models;

namespace OneToMany_task.ViewComponents
{
	public class SliderViewComponent:ViewComponent
	{
		private readonly AppDbContext _context;

		public SliderViewComponent(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var sliderData = new SliderVMVC
			{
				Sliders = await _context.Sliders.ToListAsync(),
				SliderInfo = await _context.SliderInfos.FirstOrDefaultAsync()
			};

			return await Task.FromResult(View(sliderData));
		}

	}

	public class SliderVMVC
	{
		public List<Slider> Sliders { get; set; }
		public SliderInfo SliderInfo { get; set; }

	}
}

