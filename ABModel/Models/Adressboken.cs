using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABModel.Models
{
    public class Adressboken
    {
       
        public Guid ID { get; set; }
        public string Name { get; set; }
       
        public int Telefonnummer { get; set; }

        public string Adress { get; set; }
      
        
        public DateTime UpdateAd { get; set; }
    }
}
