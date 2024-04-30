using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioAspNet.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
