using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirtsWebMVC.Models;

namespace FirtsWebMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName, string Address)
    {
        string strOutput = "Xin chào " + FullName + " đến từ " + Address;
        ViewBag.ms = strOutput;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public string Demo()
    {
        return "Huan";
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
