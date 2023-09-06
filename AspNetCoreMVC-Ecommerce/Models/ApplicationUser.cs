using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AspNetCoreMVC_Ecommerce.Models
{
    public class ApplicationUser
    {
        [Display(Name = "Full name")]
        public string FullName { get; set; }
    }
}
