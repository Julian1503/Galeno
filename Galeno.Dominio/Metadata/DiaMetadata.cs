using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galeno.Dominio.Entidades;

namespace Galeno.Dominio.Metadata
{
    public class DiaMetadata : EntityTypeConfiguration<Dia>
    {
        public DiaMetadata()
        {
            ToTable("Dias");

            Property(x => x.Descripcion)
                .HasMaxLength(100)
                .IsRequired();

            HasMany(x => x.DiaHorarios)
                .WithRequired(x => x.Dia)
                .HasForeignKey(x => x.IdDia)
                .WillCascadeOnDelete(false);

        }
    }
}
