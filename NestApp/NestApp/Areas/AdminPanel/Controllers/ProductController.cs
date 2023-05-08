using Microsoft.AspNetCore.Mvc;

namespace NestApp.Areas.AdminPanel.Controllers
{
    [Area("NestAdmin")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
