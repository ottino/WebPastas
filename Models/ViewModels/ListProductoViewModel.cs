using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPastas.Models.ViewModels
{
    public class ListProductoViewModel
    {

        public int id { get; set; }
        public string Descripcion { get; set; }
        public DateTime fecha_alta { get; set; }
    }
}