﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Contollers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
