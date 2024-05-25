using System;
namespace OneToMany_task.Models
{
	public class BaseEntity
	{
		public int  Id { get; set; }
		public bool SoftDeleted { get; set; } = false;
	}
}

