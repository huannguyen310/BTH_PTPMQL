using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirtsWebMVC.Models
{
    [Table("Persons")]
    //BTH slide 20_c7
    public class Person
    {
        [Key]
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        
        
    }
}