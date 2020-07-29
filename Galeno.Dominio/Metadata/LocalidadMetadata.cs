using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Galeno.Dominio.Entidades;




namespace Galeno.Dominio.Metadata
{
    public class LocalidadMetadata : EntityTypeConfiguration<Localidad>
    {
        public LocalidadMetadata()
        {
            ToTable("Localidades");

            Property(x => x.Descripcion)
                .HasMaxLength(250)
                .IsRequired();

            HasMany(x => x.Establecimientos)
                .WithRequired(x => x.Localidad)
                .HasForeignKey(x => x.IdLocalidad)
                .WillCascadeOnDelete(false);

        }
    }
}
