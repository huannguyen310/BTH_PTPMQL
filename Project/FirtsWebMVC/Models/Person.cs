using System.ComponentModel.DataAnnotations;
namespace FirtsWebMVC.Models
{
    //BTH slide 20_c7
    public class Person
    {
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}