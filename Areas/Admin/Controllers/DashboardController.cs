﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace Pustok.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

