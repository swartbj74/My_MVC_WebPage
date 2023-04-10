using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using My_MVC_WebPage.Models;

namespace Shopping.Controllers;

public class ShoppingController : Controller
{
    private readonly ILogger<ShoppingController> _logger;

    public ShoppingController(ILogger<ShoppingController> logger)
    {
        _logger = logger;
    }

    public IActionResult Cart()
    {
        return View();
    }
    public IActionResult Products()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
