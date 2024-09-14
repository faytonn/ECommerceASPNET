using ECommerceBackendASPNET.DataAccessLayer;
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
			var students = _dbContext.Products.Include(x => x.Category).ToList();
			return View(students);
		}
	}
}
