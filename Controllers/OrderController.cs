using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using My_MVC_WebPage.Models;

namespace Order.Controllers;

public class OrderController : Controller
{
    private readonly ILogger<OrderController> _logger;

    public OrderController(ILogger<OrderController> logger)
    {
        _logger = logger;
    }

     public IActionResult Login()
    {
        return View();
    }

     public IActionResult Register()
    {
        return View();
    }

    public IActionResult Reset()
    {
        return View();
    }

      public IActionResult Profile()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
