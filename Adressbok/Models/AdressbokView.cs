using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Adressbok.Models
{
    public class AdressbokView
    {
        [DisplayName("Bok ID")]
        public Guid ID { get; set; }

        [Required(ErrorMessage ="Du måste skriva Name")]
        [StringLength(10,ErrorMessage ="Max Name 20 Chart"),MinLength(4)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mobile no. is required")]
        //[RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public int Telefonnummer { get; set; }
        
        public string Adress { get; set; }
        //[DisplayFormat(DataFormatString = "{MMM dd, yyyy}")]
        public DateTime UpdateAd { get; set; }
    }
}