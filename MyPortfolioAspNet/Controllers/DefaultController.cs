using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioAspNet.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
