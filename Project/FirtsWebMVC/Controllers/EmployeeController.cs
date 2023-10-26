using FirtsWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace FirtsWebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Action1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Action1(Employee emp)
        {
            string empOutput = "ID: " + emp.EmployeeId + " - Name: " + emp.FullName.ToUpper() + " - Dia chi: " + " - Age: " + emp.Age;
            ViewBag.thongbao = empOutput;
            return View();
        }
        public IActionResult Action2()
        {
            return View();
        }
    }
}