using Microsoft.AspNetCore.Mvc;

namespace FirtsWebMVC.Controllers
{
    public class TinhLuongController : Controller
    {
        public IActionResult TinhLuong()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TinhLuong(string LCB, string HS, string PC)
        {
            double cb = 0, hs = 0, pc = 0, luong = 0;
            string trave;
            if(!String.IsNullOrEmpty(LCB)) cb = Convert.ToDouble(LCB);
            if(!String.IsNullOrEmpty(HS)) hs = Convert.ToDouble(HS);
            if(!String.IsNullOrEmpty(PC)) pc = Convert.ToDouble(PC);
            luong = cb * hs + pc;
            trave = "Luong cua ban: " + luong + " USDT";
            ViewBag.tl = trave;
            return View();
        }
    }
}