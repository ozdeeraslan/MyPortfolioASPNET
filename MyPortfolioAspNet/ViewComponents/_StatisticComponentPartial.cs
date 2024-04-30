using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioAspNet.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
