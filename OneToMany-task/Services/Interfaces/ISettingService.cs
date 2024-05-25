using System;
namespace OneToMany_task.Services.Interfaces
{
	public interface ISettingService
	{
		Task<Dictionary<string, string>> GetAllAsync();
	}
}

