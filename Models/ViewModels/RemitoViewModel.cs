using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPastas.Models.ViewModels
{
    public class RemitoViewModel
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Accion a realizar")]
        public int tipoMovimiento_id { get; set; }

        public int usuario_id { get; set; }

        [Required]
        [Display(Name = "Producto")]
        public int producto_id { get; set; }

        [Required]
        [Display(Name = "Cantidad")]
        public int cantidad { get; set; }

        [Required]
        [Display(Name = "Detalle del remito")]
        public string motivo { get; set; }

        [Required]
        public int camara_id { get; set; }
    }

    /*
    public class Tiposmovimiento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

    public class Productos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
    */
}