using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPastas.Models;

namespace WebPastas.Filters
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple =false)]
    public class AutorizaUsuario:AuthorizeAttribute
    {

        private seg_usuario oUsuario;
        private wi200122_pastas_tEntities db = new wi200122_pastas_tEntities();
        private int idOperacion;

        public AutorizaUsuario(int idOperacion = 0)
        {
            this.idOperacion = idOperacion;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            String nombreOperacion = "";
            String nombreModulo = "";
            try
            {
                oUsuario = (seg_usuario)HttpContext.Current.Session["User"];
                var lstMisOperaciones = from m in db.seg_rol_operacion
                                        where m.rol_id == oUsuario.rol_id
                                            && m.operacion_id == idOperacion
                                        select m;


                if (lstMisOperaciones.ToList().Count() == 0)
                {
                    var oOperacion = db.seg_operacion.Find(idOperacion);
                    int? idModulo = oOperacion.modulo_id;
                    nombreOperacion = getNombreDeOperacion(idOperacion);
                    nombreModulo = getNombreDelModulo(idModulo);
                    filterContext.Result = new RedirectResult("~/Error/SinAutorizacion?operacion=" + nombreOperacion + "&modulo=" + nombreModulo + "&msjeErrorExcepcion=");
                }
            }
            catch (Exception ex)
            {
                filterContext.Result = new RedirectResult("~/Error/SinAutorizacion?operacion=" + nombreOperacion + "&modulo=" + nombreModulo + "&msjeErrorExcepcion=" + ex.Message);
            }
        }

        public string getNombreDeOperacion(int idOperacion)
        {
            var ope = from op in db.seg_operacion
                      where op.id == idOperacion
                      select op.nombre;
            String nombreOperacion;
            try
            {
                nombreOperacion = ope.First();
            }
            catch (Exception)
            {
                nombreOperacion = "";
            }
            return nombreOperacion;
        }

        public string getNombreDelModulo(int? idModulo)
        {
            var modulo = from m in db.seg_modulo
                         where m.id == idModulo
                         select m.nombre;
            String nombreModulo;
            try
            {
                nombreModulo = modulo.First();
            }
            catch (Exception)
            {
                nombreModulo = "";
            }
            return nombreModulo;
        }


    }
}