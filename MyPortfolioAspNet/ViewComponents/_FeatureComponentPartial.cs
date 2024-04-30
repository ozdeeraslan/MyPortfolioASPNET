using Microsoft.AspNetCore.Mvc;
using MyPortfolioAspNet.DAL.Context;

namespace MyPortfolioAspNet.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext _context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = _context.Features.ToList();
            return View(values);
        }
    }
}
