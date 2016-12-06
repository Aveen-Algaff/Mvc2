using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BildGallery.Models;
using System.Data.Entity.Infrastructure;

namespace BildGallery.DAL
{
    public class GalleryDBContext: DbContext
    {
        public GalleryDBContext(): base("name=GalleryDBContext")
        {
            //Database.SetInitializer<GalleryDBContext>(new CreateDatabaseIfNotExists<GalleryDBContext>());
            
        }
        public DbSet<Gallery> Gallerys { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Album> Albums { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}
    }
}