using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BildGallery.Models
{
    public class Album
    {
        public Album()
        {
            this.Photos = new HashSet<Photo>();
        }
        [Key]
        public Guid AlbumId { get; set; }
        public string AlbumName { get; set; }
        public DateTime AlbumDate { get; set; }
        public string Description { get; set; }

        //[Display(Name = "Gallery ID")]
        //[ForeignKey("GalleryID")]
        public Guid Gallery_ID { get; set; }

        public virtual Gallery Gallerys { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
    }
}