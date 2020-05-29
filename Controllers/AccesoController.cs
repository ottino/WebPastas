﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPastas.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string User, string Pass)
        {
            try
            {
                using (Models.wi200122_pastas_tEntities2 db = new Models.wi200122_pastas_tEntities2())
                {
                    var oUser = (from d in db.usuario
                                 where d.nombre == User.Trim()
                                         && d.password == Pass.Trim()
                                 select d).FirstOrDefault();

                    if(oUser == null)
                    {
                        ViewBag.Error = "Usuario o Contraseña invalida";
                        return View();
                    }

                    Session["User"] = oUser;
                }

                return RedirectToAction("Index", "Home");     
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }

        }
    }
}