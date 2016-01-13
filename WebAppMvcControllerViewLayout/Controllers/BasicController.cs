using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMvcControllerViewLayout.Controllers
{
    public class ObjectComplex
    {
        public char character;
        public string name;
    }
    public class BasicController : Controller
    {
        //
        // GET: /Basic/

        public ActionResult Index()
        {
            return View();
        }

        public void Test()
        {

        }

        public ActionResult Helpers()
        {
            return View();
        }

        public ActionResult RequestQueryStringParam(int cod, string name)
        {
            ViewBag.cod = "RequestQueryStringParam: " + cod;
            ViewBag.name = "RequestQueryStringParam: " + name;
            return View();
        }

        public ActionResult RequestRouteParam(int id)
        {
            ViewBag.id = "RequestRouteParam: " + id;
            return View();
        }        

        public ActionResult PassingData()
        {
            ViewBag.ViewBagParam1 = "text raw";
            ViewData["ViewDataParam1"] = 1;

            TempData["TempDataParam1"] = 1.1;
            Session["SessionParam1"] = true;

            ViewBag.ObjectComplex = new ObjectComplex{ character = 'a', name = "Sam" };

            return View();
        }

        public ActionResult BundleSequence()
        {
            return View();
        }

        public string Calc(int v1, int v2)
        {
            return (v1 + v2).ToString();
        }



    }
}
