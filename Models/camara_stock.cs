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
    
    public partial class camara_stock
    {
        public int id { get; set; }
        public int camara_id { get; set; }
        public Nullable<int> producto_id { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
    
        public virtual producto producto { get; set; }
    }
}
