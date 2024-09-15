using ECommerceBackendASPNET.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;

namespace ECommerceBackendASPNET.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDBContext _dbContext;

        public HeaderViewComponent(AppDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            var header = await _dbContext.Headers.SingleOrDefaultAsync();

            return View(header);
        }
    }
}
