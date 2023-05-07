﻿using Microsoft.AspNetCore.Mvc;

namespace LayoutforMultipleViewsCoreMVC6.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public IActionResult Index()
    {
      return View();
    }

    [Route("about-company")]
    public IActionResult About()
    {
      return View();
    }

    [Route("contact-support")]
    public IActionResult Contact()
    {
      return View();
    }
  }
}
