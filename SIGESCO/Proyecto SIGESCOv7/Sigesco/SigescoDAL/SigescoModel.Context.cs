﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SigescoDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SigescoEntities : DbContext
    {
        public SigescoEntities()
            : base("name=SigescoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ANUNCIOS> ANUNCIOS { get; set; }
        public DbSet<COMUNA> COMUNA { get; set; }
        public DbSet<CONDOMINIO> CONDOMINIO { get; set; }
        public DbSet<ESPACIOS_COMUNES> ESPACIOS_COMUNES { get; set; }
        public DbSet<GASTO> GASTO { get; set; }
        public DbSet<LIBRO_SUCESOS> LIBRO_SUCESOS { get; set; }
        public DbSet<PAGO> PAGO { get; set; }
        public DbSet<PAGOXGASTO> PAGOXGASTO { get; set; }
        public DbSet<PERSONA> PERSONA { get; set; }
        public DbSet<REGION> REGION { get; set; }
        public DbSet<RESERVA> RESERVA { get; set; }
        public DbSet<RESIDENTE> RESIDENTE { get; set; }
        public DbSet<TIPO_GASTO> TIPO_GASTO { get; set; }
        public DbSet<TIPO_PAGO> TIPO_PAGO { get; set; }
        public DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
        public DbSet<USUARIO_X_CONDOMINIO> USUARIO_X_CONDOMINIO { get; set; }
        public DbSet<VIVIENDA> VIVIENDA { get; set; }
    }
}
