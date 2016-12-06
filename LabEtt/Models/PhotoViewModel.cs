using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LabEtt.Models
{
    public class PhotoViewModel
    {
        [DisplayName("Gallery")]
        public Guid ID { get; set; }
        [DisplayName("Photo Name")]
        public string PhotoName { get; set; }
        public string  ImagPath { get; set; }
        public string description { get; set; }
        
    }
}