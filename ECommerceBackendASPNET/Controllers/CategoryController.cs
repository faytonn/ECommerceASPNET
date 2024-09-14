using ECommerceBackendASPNET.DataAccessLayer;
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
			var categories = _dbContext.Categories.Include(x => x.Products).ToList();
			return View(categories);
		}
	}
}
