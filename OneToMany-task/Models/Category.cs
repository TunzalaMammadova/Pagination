using System;
using System.ComponentModel.DataAnnotations;

namespace OneToMany_task.Models
{
	public class Category:BaseEntity
	{
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

