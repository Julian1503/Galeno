using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Galeno.Dominio.Entidades;



namespace Galeno.Dominio.Metadata
{
    public class EstablecimientoMetadata : EntityTypeConfiguration<Establecimiento>
    {
        public EstablecimientoMetadata()
        {
            ToTable("Establecimientos");

            Property(x => x.Direccion)
                .HasMaxLength(200)
                .IsRequired();

           Property(x => x.IdLocalidad)
                .IsRequired();

            Property(x => x.RazonSocial)
                .HasMaxLength(150)
                .IsRequired();


            HasMany(x => x.PrestadorEstablecimientos)
                .WithRequired(x => x.Establecimiento)
                .HasForeignKey(x => x.IdEstablecimiento)

                .WillCascadeOnDelete(false);



            HasRequired(x => x.Localidad)
                .WithMany(x => x.Establecimientos)
                .HasForeignKey(x => x.IdLocalidad)
                .WillCascadeOnDelete(false);

        }
    }
}
