﻿using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.LayoutViewComponents
{
    public class _HeadLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
