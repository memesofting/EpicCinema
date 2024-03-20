using EpicCinema.Models;
using Microsoft.AspNetCore.Mvc;

namespace EpicCinema.Controllers
{
	public class MovieCategoriesController : Controller
	{
		public IActionResult Index()
		{
			var categories = MoviesRepository.ReadCategories();
			return View(categories);
		}
		
		public IActionResult Category(int? id)
		{
			var category = new Category { Id = id.HasValue ? id.Value : 0 };
			return View(category);
		}
	}
}