using Microsoft.AspNetCore.Mvc;
using MyPortfolioAspNet.DAL.Context;

namespace MyPortfolioAspNet.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext _context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = _context.Skills.Count();
			ViewBag.v2 = _context.Messages.Count();
			ViewBag.v3 = _context.Messages.Where(x => x.IsRead == false).Count();
			ViewBag.v4 = _context.Messages.Where(x => x.IsRead == true).Count();
			return View();
		}
	}
}
