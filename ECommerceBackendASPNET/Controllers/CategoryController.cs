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
		public IActionResult Index()
		{
			var categories = _dbContext.Categories.Take(9).ToList();
			var products = _dbContext.Products.Take(9).ToList();

			var viewModel = new HomeViewModel
			{
				Categories = categories,
				Products = products
			};
			return View(viewModel);
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
