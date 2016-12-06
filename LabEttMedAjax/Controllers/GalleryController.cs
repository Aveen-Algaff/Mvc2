using GModel.Models;
using GModel.Repositories;
using LabEttMedAjax.Models;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LabEttMedAjax.Controllers
{
    public class GalleryController : Controller
    {
        public PhotoRepository PhotoRepository { get; set; }
        public GalleryController()
        {
            PhotoRepository = new PhotoRepository();
        }
        // GET: Gallery
        public ActionResult Index()
        {
            ViewBag.ClientIp = Request.UserHostAddress;
            ViewBag.QueryString = Request.QueryString;
            ViewBag.RawUrl = Request.RawUrl;
            return View();
        }

        // GET: Gallery/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Detail = PhotoRepository.Photos.Where(g => g.ID == id).FirstOrDefault();
            if (Detail == null)
            {
                return HttpNotFound();
            }
            return View(Detail);
        }

        //GET 
        //[HttpGet]
        //public ActionResult Upload()
        //{
        //    return View("Index");
        //}
        
        [HttpPost]
        public ActionResult Upload(PhotoViewModel AddGallery, HttpPostedFileBase file)
        {
            if (string.IsNullOrWhiteSpace(AddGallery.PhotoName))
            {
                ModelState.AddModelError("error", "Namnet får inte vara tomt!");
                return View("error",AddGallery);
            }
            if (file == null || file.ContentLength == 0)
            {
                ModelState.AddModelError("error", "En fil vill jag gärna att du laddar upp!");

                // Vi skickar med model tillbaka så att vi kan få Name förifyllt!
                return PartialView("error",AddGallery);
            }
            var destination = Server.MapPath("~/GalleryFolder/");
            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }
            file.SaveAs(Path.Combine(destination, file.FileName));
            var photo = new Photo
            {
                ID = Guid.NewGuid(),
                ImagPath = file.FileName,
                PhotoName = AddGallery.PhotoName
            };
            PhotoRepository.Add(photo);
            return RedirectToAction("List");
        }
        public ActionResult List()
        {

            return View(PhotoRepository.Photos);
        }
        // GET: Gallery/Edit/5
        public ActionResult Edit(Guid id)
        {
            var E = PhotoRepository.Photos.Where(p => p.ID == id).FirstOrDefault();
            return View(E);
        }

        // POST: Gallery/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, Photo EG)
        {
            try
            {
                var E = PhotoRepository.Photos.Where(p => p.ID == id).FirstOrDefault();
                E.ID = EG.ID;
                E.PhotoName = EG.PhotoName;
                E.ImagPath = EG.ImagPath;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gallery/Delete/5
        public ActionResult Delete(Guid id)
        {
            //var D =  PhotoRepository.Photos.Where(d => d.ID == id).FirstOrDefault();
            PhotoRepository.Remove(id);

            return RedirectToAction("List");
        }
    }
}