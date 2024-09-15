using ECommerceBackendASPNET.DataAccessLayer;
using ECommerceBackendASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceBackendASPNET.Controllers
{
	public class CategoryController : Controller
	{
		private readonly AppDBContext _dbContext;
		public CategoryController(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}
        public async Task<IActionResult> Index()
        {
            var categories = await _dbContext.Categories.ToListAsync();
            var products = await _dbContext.Products.Take(3).Skip(3).ToListAsync();

            var viewModel = new HomeViewModel
            {
                Categories = categories,
                Products = products
            };
            return View(viewModel);
        }

        public async Task<IActionResult> LoadProducts()
        {
            var products = await _dbContext.Products.Include(x => x.Category).Take(3).ToListAsync();

            return PartialView("_CategoryPartial", products);
        }



        public IActionResult Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var product = _dbContext.Products.Include(x => x.Category).FirstOrDefault(x => x.Id == id);

			return View(product);
		}
	}
}
