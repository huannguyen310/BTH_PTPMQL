using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirtsWebMVC.Models
{
    [Table("Employees")]
    public class Employee : Person
    {
        public string EmployeeID { get; set;}
        public int Age { get; set;}
    }
}