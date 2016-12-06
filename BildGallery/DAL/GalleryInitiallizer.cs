using BildGallery.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BildGallery.DAL
{
    public class GalleryInitiallizer : DropCreateDatabaseIfModelChanges<GalleryDBContext>
    {
        protected override void Seed(GalleryDBContext context)
        {
                       
            Album alb = new Album();
           

           var gallery = new List<Gallery>
            {
           new Gallery{ GalleryID=Guid.NewGuid(), GalleryName="Galler 01",GalleryDate=DateTime.UtcNow}
            };
            gallery.ForEach(g => context.Gallerys.Add(g));
            var Gid = gallery.Select(g => g.GalleryID).FirstOrDefault();
            var album = new List<Album>
            {
                new Album {AlbumId=Guid.NewGuid(), AlbumName="Album01",AlbumDate=DateTime.UtcNow,Description="First Album",Gallery_ID=Gid }
            };
            album.ForEach(al=> context.Albums.Add(al));
            var albid = album.Select(albs => albs.AlbumId).FirstOrDefault();
            var phtot = new List<Photo>
            {
                new Photo {PhotoID=Guid.NewGuid(), PhotoName="img01",PhotoDate=DateTime.UtcNow,PhotoPath=@"C:\Users\ali_n\Source\Repos\MVC\MVCProject\BildGallery\GalleryPhoto\img01.jpg",Album_Id=albid}
            };
            phtot.ForEach(p => context.Photos.Add(p));
        }
    }
}