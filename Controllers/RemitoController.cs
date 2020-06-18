using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPastas.Models;
using WebPastas.Models.ViewModels;

namespace WebPastas.Controllers
{
    public class RemitoController : Controller
    {

        // GET: Remito
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {

            List<TipoMovimientoViewModel> lst_tm;
            List<ProductoViewModel> lst_pr;

            // Levanto todos los list para mostrar en la pantalla de remito
            using (wi200122_pastas_tEntities db = new wi200122_pastas_tEntities())
            {
                // Tipos de Movimientos
                lst_tm = (
                 from d in db.tipo_movimiento
                 select new TipoMovimientoViewModel
                 {
                     Id = d.id,
                     Descripcion = d.descripcion,
                 }
                ).ToList();

                // Listado de Productos
                lst_pr = (
                 from d in db.producto
                 select new ProductoViewModel
                 {
                     id = d.id,
                     Descripcion = d.descripcion,
                 }
                ).ToList();


            }

            List<SelectListItem> items_tm = lst_tm.ConvertAll(
                d =>
                {
                    return new SelectListItem()
                    {
                        Text = d.Descripcion,
                        Value = d.Id.ToString(),
                        Selected = false
                    };

                }
            );

            List<SelectListItem> items_pr = lst_pr.ConvertAll(
                d =>
                {
                    return new SelectListItem()
                    {
                        Text = d.Descripcion,
                        Value = d.id.ToString(),
                        Selected = false
                    };

                }
            );

            ViewBag.items_html_tm = items_tm;
            ViewBag.items_html_pr = items_pr;

            return View();
        }

        [HttpPost]
        public ActionResult Add(RemitoViewModel model)
        {

            //var xxx = Request.Form;
            //var zzz = model.[0].Descripcion;

            try
            {
                if (ModelState.IsValid) // valida los DataAnotations
                {
                    using (wi200122_pastas_tEntities db = new wi200122_pastas_tEntities())
                    {

                        db.sp_movimientos_stock(model.tipoMovimiento_id, model.camara_id, model.producto_id, model.cantidad);
                        
                        /*
                        var oProducto = new producto();

                        oProducto.descripcion = model.Descripcion;
                        oProducto.fecha_alta = DateTime.Today;

                        db.producto.Add(oProducto);
                        db.SaveChanges();
                        */
                    }
                }

                return Redirect("~/Remito/");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}