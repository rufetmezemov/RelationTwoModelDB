﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetweenTwoModelDB.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
