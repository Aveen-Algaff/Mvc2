using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BildGallery.Models
{
    public class Gallery
    {
        public Gallery()
        {
            this.Album = new HashSet<Album>();
        }
        [Key]
        public Guid GalleryID { get; set; }
        public string GalleryName { get; set; }
        public DateTime GalleryDate { get; set; }

        public virtual ICollection<Album> Album { get; set; }
    }
}