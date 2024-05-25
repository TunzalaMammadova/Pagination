using System;
using System.ComponentModel.DataAnnotations;

namespace OneToMany_task.ViewModels.Categories
{
	public class CategoryCreateVM
	{
        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(10, ErrorMessage = "Length must be max 20")]
        public string Name { get; set; }
	}
}

