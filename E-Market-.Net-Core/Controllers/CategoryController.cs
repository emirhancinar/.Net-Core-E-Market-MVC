using Microsoft.AspNetCore.Mvc;
using E_Market_.Net_Core.Models.DB_Classes;

namespace E_Market_.Net_Core.Controllers
{
    public class CategoryController : Controller
    {
        MarketContext marketContext = new MarketContext();
        public IActionResult Index()
        {
            var values=marketContext.Categories.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategories()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategories(Category category)
        {
            marketContext.Categories.Add(category);
            marketContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CategoryDelete(int id)
        {
            var category = marketContext.Categories.Find(id);
            marketContext.Categories.Remove(category);
            marketContext.SaveChanges();
            return RedirectToAction("Index");
        }
		
		[HttpPost]
		public ActionResult UpdateCategory(int id)
		{
			var category = marketContext.Categories.Find(id);
            return View("UpdateCategory", category);
        }

	}
}
