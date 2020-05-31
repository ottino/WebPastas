using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPastas.Filters;

namespace WebPastas.Controllers
{
    public class HomeController : Controller
    {
        [AutorizaUsuario(idOperacion:1)]
        public ActionResult Index()
        {
            return View();
        }

        [AutorizaUsuario(idOperacion: 2)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [AutorizaUsuario(idOperacion: 5)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}