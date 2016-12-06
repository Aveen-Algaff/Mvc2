using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GModel.Models
{
    public class Photo
    {
        public Guid ID { get; set; }   
        public string PhotoName { get; set; }
        public string ImagPath { get; set; }
        public string description { get; set; }

    }
}
