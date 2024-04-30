using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioAspNet.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
