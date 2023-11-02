using Microsoft.EntityFrameworkCore;
using FirtsWebMVC.Models;

namespace FirtsWebMVC.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;}
    }
}