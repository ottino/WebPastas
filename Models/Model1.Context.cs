﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class wi200122_pastas_tEntities : DbContext
    {
        public wi200122_pastas_tEntities()
            : base("name=wi200122_pastas_tEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<seg_modulo> seg_modulo { get; set; }
        public DbSet<seg_operacion> seg_operacion { get; set; }
        public DbSet<seg_rol> seg_rol { get; set; }
        public DbSet<seg_rol_operacion> seg_rol_operacion { get; set; }
        public DbSet<seg_usuario> seg_usuario { get; set; }
        public DbSet<producto> producto { get; set; }
        public DbSet<stock> stock { get; set; }
    }
}
