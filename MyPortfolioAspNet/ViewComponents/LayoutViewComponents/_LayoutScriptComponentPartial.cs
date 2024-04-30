using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioAspNet.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
