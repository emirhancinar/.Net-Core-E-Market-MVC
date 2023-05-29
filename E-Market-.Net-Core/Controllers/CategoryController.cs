using Microsoft.AspNetCore.Mvc;

namespace E_Market_.Net_Core.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
