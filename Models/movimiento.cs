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
    
    public partial class movimiento
    {
        public int id { get; set; }
        public Nullable<System.DateTime> fecha_movimiento { get; set; }
        public Nullable<int> tipoMovimiento_id { get; set; }
        public Nullable<decimal> usuario_id { get; set; }
        public Nullable<int> producto_id { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public string motivo_descripcion { get; set; }
        public Nullable<int> destino_empleadoId { get; set; }
        public Nullable<int> destino_camaraId { get; set; }
        public Nullable<int> destino_clienteId { get; set; }
    
        public virtual producto producto { get; set; }
        public virtual seg_usuario seg_usuario { get; set; }
        public virtual tipo_movimiento tipo_movimiento { get; set; }
    }
}
