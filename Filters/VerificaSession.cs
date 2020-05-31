using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPastas.Controllers;
using WebPastas.Models;

namespace WebPastas.Filters
{
    public class VerificaSession : ActionFilterAttribute
    {
        private seg_usuario oUsuario;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {

                    /* Aca pongo lo primero que va a realizar cuando se llame a este metodo */
            
                    /* Esto lo hace cuando termine lo que yo quiero */
                    base.OnActionExecuting(filterContext);

                    // Tomo la session del usuario logeado
                    oUsuario = (seg_usuario)HttpContext.Current.Session["User"];

                    if (oUsuario == null)
                    {
                        if (filterContext.Controller is AccesoController == false)
                        {
                            filterContext.HttpContext.Response.Redirect("~/Acceso/Login");
                        }

                    }
                /*
                else
                {
                    if (filterContext.Controller is AccesoController == true)
                    {
                        filterContext.HttpContext.Response.Redirect("~/Home/Index");
                    }

                }
                */
            }
            catch (Exception)
            {
                filterContext.HttpContext.Response.Redirect("~/Acceso/Login");
            }

        }

    }
}