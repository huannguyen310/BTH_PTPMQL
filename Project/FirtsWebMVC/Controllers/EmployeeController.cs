using FirtsWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using FirtsWebMVC.Models.Process;
namespace FirtsWebMVC.Controllers
{
    //BTH slide 17_c7
    public class EmployeeController : Controller
    {
        StringProcess strPro = new StringProcess();
        public IActionResult Action1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Action1(Employee emp)
        {
            ViewBag.thongbao = "ID: " + emp.EmployeeId + " - Name: " + strPro.StringToUpper(emp.FullName) + " - Dia chi: " + " - Age: " + emp.Age;
            return View();
        }
        public IActionResult Action2()
        {
            return View();
        }
    }
}