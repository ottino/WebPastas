//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPastas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto
    {
        public producto()
        {
            this.stock = new HashSet<stock>();
            this.camara_stock = new HashSet<camara_stock>();
            this.movimiento = new HashSet<movimiento>();
        }
    
        public int id { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fecha_alta { get; set; }
    
        public virtual ICollection<stock> stock { get; set; }
        public virtual ICollection<camara_stock> camara_stock { get; set; }
        public virtual ICollection<movimiento> movimiento { get; set; }
    }
}
