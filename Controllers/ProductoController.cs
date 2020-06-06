using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPastas.Models;
using WebPastas.Models.ViewModels;

namespace WebPastas.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            List<ListProductoViewModel> listado_productos;

            using (Models.wi200122_pastas_tEntities db = new Models.wi200122_pastas_tEntities() )
            {
                    listado_productos = (from list in db.producto
                                        select new ListProductoViewModel // Modesl/ViewModel
                                        {
                                            id = list.id,
                                            Descripcion = list.descripcion,
                                        }).ToList();
            }

            return View(listado_productos);
        }
    }
}