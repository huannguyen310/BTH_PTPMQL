using System.ComponentModel.DataAnnotations;
namespace FirtsWebMVC.Models
{
    //BTH slide 20_c7
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public int Age { get; set; }
    }
}