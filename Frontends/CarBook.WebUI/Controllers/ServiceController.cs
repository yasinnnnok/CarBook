﻿using Carbook.Dto.ServiceDtos;
using Carbook.Dto.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
    public class ServiceController : Controller
    {


        public IActionResult Index()
        {

            return View();
        }
    }
}
