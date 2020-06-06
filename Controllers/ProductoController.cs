﻿using System;
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

        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Add(ProductoViewModel model)
        {
            try
            {
                if(ModelState.IsValid) // valida los DataAnotations
                {
                    using (wi200122_pastas_tEntities db = new wi200122_pastas_tEntities())
                    {
                        var oProducto = new producto();
                        oProducto.descripcion = model.Descripcion;

                        db.producto.Add(oProducto);
                        db.SaveChanges();

                    }
                }

                return Redirect("Producto/");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}