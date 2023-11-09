using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FirtsWebMVC.Models
{
    [Table("HeThongPhanPhoi")]
    //BTH slide 20_c7
    public class HeThongPhanPhoi
    {
        [Key]
        public string MaHTTP { get; set; }
        public string TenHTTP { get; set; }
    }
}