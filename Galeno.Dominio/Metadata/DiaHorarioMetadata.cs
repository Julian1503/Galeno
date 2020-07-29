using Galeno.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;


namespace Galeno.Dominio.Metadata
{
    public class DiaHorarioMetadata : EntityTypeConfiguration<DiaHorario>
    {
        public DiaHorarioMetadata()
        {
            ToTable("DiaHorarios");

            Property(x => x.IdDia)
                .IsRequired();

            Property(x => x.IdHorarioPrestador)
                .IsRequired();

            HasRequired(x => x.Dia)
            .WithMany(x => x.DiaHorarios)
            .HasForeignKey(x => x.IdDia)
            .WillCascadeOnDelete(false);

            HasRequired(x => x.HorarioPrestador)
            .WithMany(x => x.DiaHorarios)
            .HasForeignKey(x => x.IdHorarioPrestador)
            .WillCascadeOnDelete(false);

        }

    }
}
