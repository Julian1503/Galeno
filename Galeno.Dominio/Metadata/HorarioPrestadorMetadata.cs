using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Net.Http.Headers;
using System.Text;
using Galeno.Dominio.Entidades;



namespace Galeno.Dominio.Metadata
{
    public class HorarioPrestadorMetadata : EntityTypeConfiguration<HorarioPrestador>
    {
        public HorarioPrestadorMetadata()
        {
            ToTable("HorarioPrestadores");

            Property(x => x.IdPrestadorEstablecimiento)
                .IsRequired();

            Property(x => x.HoraFin)
                .HasColumnType("Time")
                .IsRequired();

            Property(x => x.HoraInicio)
                .HasColumnType("Time")
                .IsRequired();

            HasRequired(x => x.PrestadorEstablecimiento)
                .WithMany(x => x.HorarioPrestadores)
                .HasForeignKey(x => x.IdPrestadorEstablecimiento)
                .WillCascadeOnDelete(false);

           HasMany(x => x.DiaHorarios)
                .WithRequired(x => x.HorarioPrestador)
                .HasForeignKey(x => x.IdHorarioPrestador)
                .WillCascadeOnDelete(false);
        }
    }
}
