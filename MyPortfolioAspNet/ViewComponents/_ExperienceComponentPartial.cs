using Microsoft.AspNetCore.Mvc;
using MyPortfolioAspNet.DAL.Context;

namespace MyPortfolioAspNet.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
