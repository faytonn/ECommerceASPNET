using ECommerceBackendASPNET.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;

namespace ECommerceBackendASPNET.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDBContext _dbContext;

        public FooterViewComponent(AppDBContext dBContext)
        {
            _dbContext = dBContext;   
        }

        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            var footer = await _dbContext.Footers.SingleOrDefaultAsync();

            return View(footer);
        }
    }
}
