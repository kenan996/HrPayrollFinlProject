﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HrPayrollFinalProject.Controllers
{
    public class PenaltyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}