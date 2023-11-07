using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirtsWebMVC.Data;
using FirtsWebMVC.Models;

namespace FirtsWebMVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PersonController(ApplicationDbContext context)
        public async Task<IActionResult> Index()
        {}
        public IActionResult Create()
        {}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId, FullName, Address")] Person person)
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
        private bool Personexists(string id)
        {
            
        }
    }
}