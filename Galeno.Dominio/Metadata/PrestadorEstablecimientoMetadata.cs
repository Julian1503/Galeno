using Galeno.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Galeno.Dominio.Metadata
{
    public class PrestadorEstablecimientoMetadata : EntityTypeConfiguration<PrestadorEstablecimiento>
    {
        public PrestadorEstablecimientoMetadata()
        {
            ToTable("PrestadorEstablecimientos");

            Property(x => x.IdEstablecimiento)
                 .IsRequired();

            Property(x => x.IdPrestadorEspecialidad)
                .IsRequired();

            HasRequired(x => x.PrestadorEspecialidad)
                   .WithMany(x => x.PrestadorEstablecimientos)
                   .HasForeignKey(x => x.IdPrestadorEspecialidad)
                   .WillCascadeOnDelete(false);

            HasRequired(x => x.Establecimiento)
                .WithMany(x => x.PrestadorEstablecimientos)
                .HasForeignKey(x => x.IdEstablecimiento)
                .WillCascadeOnDelete(false);
        }
    }
}
