using ECommerceBackendASPNET.DataAccessLayer;
using ECommerceBackendASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceBackendASPNET.Controllers
{
	public class ProductController : Controller
	{
		private readonly AppDBContext _dbContext;
		public ProductController(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IActionResult Index()
		{
			//var categories = _dbContext.Categories.ToList();
			//var products = _dbContext.Products.Take(9).ToList();

			//var viewModel = new HomeViewModel
			//{
			//	Categories = categories,
			//	Products = products
			//};
			return View();
		}

        //public IActionResult LoadProducts(int skip)
        //{
        //    var products = _dbContext.Products.Include(x => x.Category).Skip(skip).Take(9).ToList();

        //    return PartialView("_CategoryPartial", products);
        //}

        public IActionResult Details(int? id)
		{
			if(id == null)
			{
				return NotFound();
			}
			var products = _dbContext.Products.Include(x=>x.Category).FirstOrDefault(x=>x.Id == id);

			return View(products);
		}
	}
}
