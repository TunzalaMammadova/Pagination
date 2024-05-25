using System;
using System.ComponentModel.DataAnnotations;
using OneToMany_task.Models;

namespace OneToMany_task.ViewModels.Sliders
{
	public class SliderCreateVM
	{
		[Required]
		public List<IFormFile> Images { get; set; }
	}
}

