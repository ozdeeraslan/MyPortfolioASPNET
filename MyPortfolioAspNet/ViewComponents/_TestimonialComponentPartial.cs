﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioAspNet.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
