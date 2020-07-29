using Galeno.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;




namespace Galeno.Dominio.Metadata
{
    public class EspecialidadMetadata : EntityTypeConfiguration<Especialidad>
    {
        public EspecialidadMetadata()
        {
            ToTable("Especialidades");

            Property(x => x.Descripcion)
                .HasMaxLength(100)
                .IsRequired();

            HasMany(x => x.PrestadorEspecialidades)
                .WithRequired(x => x.Especialidad)
                .HasForeignKey(x => x.IdEspecialidad)
                .WillCascadeOnDelete(false);

        }
    }
}
