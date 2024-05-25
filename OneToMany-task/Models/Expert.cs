using System;
namespace OneToMany_task.Models
{
	public class Expert : BaseEntity
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string Name { get; set; }
		public string Profession { get; set; }

	}
}

