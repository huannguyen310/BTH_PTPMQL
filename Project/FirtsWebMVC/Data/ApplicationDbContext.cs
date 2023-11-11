using Microsoft.EntityFrameworkCore;
using FirtsWebMVC.Models;

namespace FirtsWebMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;}
        public DbSet<Employee> Employee { get; set;}
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set;}
        public DbSet<FirtsWebMVC.Models.DaiLy> DaiLy { get; set;}
    }
}