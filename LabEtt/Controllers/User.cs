using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LabEtt.Controllers
{
    public class User
    {
        public Guid UserId { get; set; }
       [DisplayName("Full Name")]
        [Required] 
        public string FName { get; set; }
        [DisplayName("User Name")]
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Email")]
        public string ConfireEmail { get; set; }

    }
}