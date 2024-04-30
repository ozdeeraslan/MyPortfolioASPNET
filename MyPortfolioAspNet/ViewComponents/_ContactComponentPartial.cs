using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioAspNet.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
