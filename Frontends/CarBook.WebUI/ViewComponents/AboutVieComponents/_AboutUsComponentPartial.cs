﻿using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.AboutVieComponents
{
    public class _AboutUsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
