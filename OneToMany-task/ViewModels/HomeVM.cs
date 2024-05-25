using System;
using OneToMany_task.Models;

namespace OneToMany_task.ViewModels
{
	public class HomeVM
	{
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<ProductImage> ProductImage { get; set; }
        public List<Expert> Experts { get; set; }
        public List<ExpertImage> ExpertImages { get; set; }

    }
}

