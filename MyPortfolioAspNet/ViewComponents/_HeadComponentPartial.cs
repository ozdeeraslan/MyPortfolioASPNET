using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioAspNet.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
