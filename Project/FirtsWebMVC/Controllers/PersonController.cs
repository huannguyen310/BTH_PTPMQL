using FirtsWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace FirtsWebMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Action1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Action1(Person ps)
        {
            string psOutput = "Xin chào " + ps.PersonId + " - " + ps.FullName + " - " + ps.Address;
            ViewBag.infoPerson = psOutput;
            return View();
        }
        public IActionResult Action2()
        {
            return View();
        }
    }
}