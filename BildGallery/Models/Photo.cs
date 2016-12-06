using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BildGallery.Models
{
    public class Photo
    {
        public Guid PhotoID { get; set; }
        public string PhotoName { get; set; }
        public DateTime PhotoDate { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }

        //[ForeignKey("AlbumId")]
        public Guid Album_Id { get; set; }
        public virtual Album Album { get; set; }
    }
}