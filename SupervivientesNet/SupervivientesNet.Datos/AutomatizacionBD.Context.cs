﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SupervivientesNet.Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AutomatizacionEntities : DbContext
    {
        public AutomatizacionEntities()
            : base("name=AutomatizacionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> account { get; set; }
        public virtual DbSet<block> block { get; set; }
        public virtual DbSet<contact> contact { get; set; }
        public virtual DbSet<dayoftheweek> dayoftheweek { get; set; }
        public virtual DbSet<infrastructure> infrastructure { get; set; }
        public virtual DbSet<petition> petition { get; set; }
    }
}
