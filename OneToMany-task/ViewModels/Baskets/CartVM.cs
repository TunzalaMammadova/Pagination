using System;
namespace OneToMany_task.ViewModels.Baskets
{
	public class CartVM
	{
		public List<BasketProductsVM> BasketProducts{ get; set; }
		public decimal Total { get; set; }
	}
}

