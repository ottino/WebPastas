using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPastas.Models.ViewModels;

namespace WebPastas.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult Index()
        {
            List<ListStockViewModel> listado_stock;

            using (Models.wi200122_pastas_tEntities db = new Models.wi200122_pastas_tEntities())
            {
                listado_stock = (from s in db.stock
                                 join p in db.producto on s.producto_id equals p.id
                                 select new ListStockViewModel // Modesl/ViewModel
                                     {
                                         Id = s.id,
                                         Producto_id = s.producto_id,
                                         Descripcion_producto = p.descripcion,
                                         Cantidad = s.cantidad,
                                     }).ToList();
            }

            return View(listado_stock);
        }
    }
}