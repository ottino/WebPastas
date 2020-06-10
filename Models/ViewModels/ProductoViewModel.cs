using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPastas.Models.ViewModels
{
    public class ProductoViewModel
    {

        public int id { get; set; }

        [Required]
        [Display(Name ="Descripcion del producto")]
        [StringLength(100)]
        public string Descripcion { get; set; }


    }
}