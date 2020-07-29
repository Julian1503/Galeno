using Galeno.Dominio.Entidades;


using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace Galeno.Dominio.Metadata
{
    public class PrestadorMetadata : EntityTypeConfiguration<Prestador>
    {
        public PrestadorMetadata()
        {
            ToTable("Prestadores");

            Property(x => x.Apellido)
                .HasMaxLength(250)
                .IsRequired();

            Property(x => x.Nombre)
                .HasMaxLength(250)
                .IsRequired();

           HasMany(x => x.PrestadorEspecialidades)
                .WithRequired(x => x.Prestador)
                .HasForeignKey(x => x.IdPrestador)
                .WillCascadeOnDelete(false);
        }
    }
}
