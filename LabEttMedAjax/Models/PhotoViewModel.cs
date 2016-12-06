using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LabEttMedAjax.Models
{
    public class PhotoViewModel
    {
        [DisplayName("Gallery")]        
        public Guid ID { get; set; }
        [Required]
        [DisplayName("Photo Name")]
        public string PhotoName { get; set; }
        [Required]
        public string ImagPath { get; set; }
        public string description { get; set; }
    }
}