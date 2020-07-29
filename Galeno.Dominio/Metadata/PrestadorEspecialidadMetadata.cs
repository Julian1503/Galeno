using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Galeno.Dominio.Entidades;




namespace Galeno.Dominio.Metadata
{
    public class PrestadorEspecialidadMetadata : EntityTypeConfiguration<PrestadorEspecialidad>
    {
        public PrestadorEspecialidadMetadata()
        {
            ToTable("PrestadorEspecialidades");

            Property(x => x.IdEspecialidad)
                .IsRequired();

            Property(x => x.IdPrestador)
                .IsRequired();

           HasRequired(x => x.Prestador)
                .WithMany(x => x.PrestadorEspecialidades)
                .HasForeignKey(x => x.IdPrestador)
                .WillCascadeOnDelete(false);

           HasRequired(x => x.Especialidad)
                .WithMany(x => x.PrestadorEspecialidades)
                .HasForeignKey(x => x.IdEspecialidad)
                .WillCascadeOnDelete(false);

        }
    }
}
