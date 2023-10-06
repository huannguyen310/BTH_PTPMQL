using Microsoft.AspNetCore.Mvc;

namespace FirtsWebMVC.Controllers;

public class DemoController : Controller
{
    //Khai bao cac phuong thuc
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string fname, string Email)
    {
        string str = "Hello " + fname + " - " + "Email: " + Email;
        ViewBag.thongbao = str;
        return View();
    }
}