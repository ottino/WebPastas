using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPastas.Models.ViewModels
{
    public class ListStockViewModel
    {
        public int Id { get; set; }
        public int? Producto_id { get; set; }
        public string Descripcion_producto { get; set; }
        public int? Cantidad { get; set; }

    }
}