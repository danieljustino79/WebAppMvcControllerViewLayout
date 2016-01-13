using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMvcControllerViewLayout.Controllers
{
    public class MediumController : Controller
    {
        //
        // GET: /Medium/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DestinyRedirect()
        {
            return Redirect("http://localhost:34108/Medium/FinalDestinyRedirect");
        }
        public ActionResult FinalDestinyRedirect()
        {
            return View();
        }

        public ActionResult DestinyRedirectPermanent()
        {
            return RedirectPermanent("http://localhost:34108/Medium/FinalDestinyRedirectPermanent");
        }
        public ActionResult FinalDestinyRedirectPermanent()
        {
            return View();            
        }

        public ActionResult DestinyRedirectToAction()
        {
            return RedirectToAction("FinalDestinyRedirectToAction");
        }
        public ActionResult FinalDestinyRedirectToAction()
        {
            return View();            
        }

        public ActionResult DestinyRedirectToActionPermanent()
        {
            return RedirectToActionPermanent("FinalDestinyRedirectToActionPermanent");
        }
        public ActionResult FinalDestinyRedirectToActionPermanent()
        {
            return View();            
        }

        public ActionResult DestinyRedirectToRoute()
        {
            return RedirectToRoute(new { id = 1 });
        }
        public ActionResult DestinyRedirectToRoute(int id)
        {
            return View();            
        }

        public ActionResult DestinyRedirectToRoutePermanent()
        {
            return RedirectToRoutePermanent(new { id = 1 });
        }
        public ActionResult DestinyRedirectToRoutePermanent(int id)
        {
            return View();
        }
    }
}
