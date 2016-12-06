
using BildGallery.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BildGallery
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //Database.SetInitializer<GalleryDBContext>(new CreateDatabaseIfNotExists<GalleryDBContext>());
       
        protected void Application_Start()
        {
            Database.SetInitializer<GalleryDBContext>(new GalleryInitiallizer());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
