using ABModel.Models;
using ABModel.Repositories;
using Adressbok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Adressbok.Controllers
{
    public class AdressbokController : Controller
    {
        public static ABRepository ABrepositorys { get; set; }
        public AdressbokController()
        {
            ABrepositorys = new ABRepository();
        }
        // GET: Adressbok
        public ActionResult Index()
        {
            return View(ABRepository.Adressboks);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(AdressbokView Addbok)
        {
            if (ModelState.IsValid)
            {
                var add = new Adressboken
                {
                    Name = Addbok.Name,
                    Telefonnummer = Addbok.Telefonnummer,
                    Adress = Addbok.Adress,
                    UpdateAd = Addbok.UpdateAd
                };
                ABrepositorys.Add(add);
            }
            else
            {
                return View(Addbok);
            }

            //if (add!=null)
            //{
            //    return Json(new { Status = 1, Message = "Adressbok Created Successfully" }, JsonRequestBehavior.AllowGet);
            //}
            //else
            //{
            //    return Json(new { Status = 0, Message = "Adressbok Failed to Created" }, JsonRequestBehavior.AllowGet);
            //}
            return RedirectToAction("Index");
        }


        //[HttpPost]
        ////[ValidateAntiForgeryToken]
        //public ActionResult Create(AdressbokView AddAB)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var add = new Adressboken
        //        {
        //            Name=AddAB.Name,
        //            Telefonnummer=AddAB.Telefonnummer,
        //            Adress=AddAB.Adress,
        //            UpdateAd=AddAB.UpdateAd
        //        };
        //        ABrepositorys.Add(add);
        //        return RedirectToAction("List");
        //    }

        //    return View(AddAB);
        //}
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Detail = ABRepository.Adressboks.Where(g => g.ID == id).FirstOrDefault();
            if (Detail == null)
            {
                return HttpNotFound();
            }
            return View(Detail);
        }
        public ActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ABrepositorys.Remov(id);
            //if (Detail == null)
            //{
            //    return HttpNotFound();
            //}
            return RedirectToAction("Index");
        }

        public ActionResult List()
        {
            return View(ABRepository.Adressboks);
        }
    }
}