using FirtsWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirtsWebMVC.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FirtsWebMVC.Controllers
{
    //BTH_slide 17_c7
    public class PersonController : Controller
    {
        private readonly ApplicationDbcontext _context;
        public PersonController(ApplicationDbcontext context)
        {
            
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> Create()
        {
            return View();   
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId, FullName, Address")] Person person);
        {

        }
        public async Task<IActionResult> Edit(string id)
        {
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId, FullName, Address")] Person person)
        {
            
        }
        public async Task<IActionResult> Delete(string id)
        {
            
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            
        }
        private bool PersonExists(string id)
        {

        }
        
    }
}