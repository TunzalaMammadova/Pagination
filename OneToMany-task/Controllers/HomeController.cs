using System;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OneToMany_task.Data;
using OneToMany_task.Models;
using OneToMany_task.Services.Interfaces;
using OneToMany_task.ViewModels;
using OneToMany_task.ViewModels.Baskets;

namespace OneToMany_task.Controllers
{
	public class HomeController : Controller
	{
        private readonly AppDbContext _context;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IExpertService _expertService;
        private readonly IExpertImageService _expertImageService;
        private readonly IHttpContextAccessor _accessor;

        public HomeController(AppDbContext context,
                              IProductService productService,
                              ICategoryService categoryService,
                              IExpertService expertService,
                              IExpertImageService expertImageService,
                              IHttpContextAccessor accessor )
        {
            _context = context;
            _productService = productService;
            _categoryService = categoryService;
            _expertService = expertService;
            _expertImageService = expertImageService;
            _accessor = accessor;
        }

        public async Task <IActionResult> Index()
        {
            List<Category> categories = await _categoryService.GetAllAsync();
            List<Product> products = await _productService.GetAllWithImagesAsync();
            List<Blog> blogs = await _context.Blogs.Take(3).ToListAsync();
            List<Expert> experts = await _expertService.GetAllAsync();
            List<ExpertImage> expertImageService= await _expertImageService.GetAllAsync();

          


            HomeVM model = new()
            {
                Categories = categories,
                Blogs = blogs,
                Products = products,
                Experts = experts,
                ExpertImages = expertImageService
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> AddProductBasket(int? id)
        {

            if (id is null) return BadRequest();

            List<BasketVM> basketProducts = null;

            if (_accessor.HttpContext.Request.Cookies["basket"] is not null)
            {
                basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["basket"]);
            }
            else
            {
                basketProducts = new List<BasketVM>();
            }

            var dbProduct = await _context.Products.FirstOrDefaultAsync(m => m.Id == (int)id);

            var existProduct = basketProducts.FirstOrDefault(m => m.Id == (int)id);

            if (existProduct is not null)
            {
                existProduct.Count++;
            }
            else
            {
                basketProducts.Add(new BasketVM
                {
                    Id = (int)id,
                    Count = 1,
                    Price = dbProduct.Price
                });
            }

            _accessor.HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketProducts));

            int count = basketProducts.Sum(m => m.Count);
            decimal total = basketProducts.Sum(m => m.Count * m.Price);

            return Ok(new {count,total});

        }
    }
}

