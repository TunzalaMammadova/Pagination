using System;
using OneToMany_task.Models;

namespace OneToMany_task.Models
{
	public class Product : BaseEntity
	{
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImage { get; set; }
    }
}


