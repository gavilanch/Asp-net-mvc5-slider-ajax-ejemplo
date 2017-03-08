namespace ModuloAjax
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModuloAjaxApplicationDbContext : DbContext
    {
        public ModuloAjaxApplicationDbContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Direccion> Direcciones { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Direccion>()
                .Property(e => e.Cedula)
                .IsFixedLength();

            modelBuilder.Entity<Persona>()
                .Property(e => e.Cedula)
                .IsFixedLength();

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Direcciones)
                .WithRequired(e => e.Personas)
                .WillCascadeOnDelete(false);
        }
    }
}
