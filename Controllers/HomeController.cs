using Microsoft.AspNetCore.Mvc;

namespace EpicCinema.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
