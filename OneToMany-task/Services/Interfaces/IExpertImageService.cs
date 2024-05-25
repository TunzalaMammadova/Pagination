using System;
using OneToMany_task.Models;

namespace OneToMany_task.Services.Interfaces
{
	public interface IExpertImageService
	{
		Task<List<ExpertImage>>GetAllAsync();
	}
}

