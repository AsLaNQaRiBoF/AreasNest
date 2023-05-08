using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestApp.DAL;

namespace NestApp.Areas.AdminPanel.Controllers
{
	[Area("NestAdmin")]    
	
	public class CategoriesController : Controller
	{
		private readonly AppDbContext _context;
		public CategoriesController(AppDbContext context)
		{
			_context=context;
		}
		public async IActionResult Index()
        {
            View(await _context.Categories.Where(x=>x.IsDeleted==false).ToListAsync());
        }
    }
}
