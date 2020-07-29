using Galeno.Dominio.Entidades;
using MySql.Data.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Galeno.Dominio.Metadata;

namespace Galeno.Infraestructura
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DataContext : DbContext
    {
        public DataContext() : base(Conexion.Conexion.ObtenerCadenaConexionSql)
        {
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
        }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Configurations
            modelBuilder.Configurations.Add<Dia>(new DiaMetadata());
            modelBuilder.Configurations.Add<DiaHorario>(new DiaHorarioMetadata());
            modelBuilder.Configurations.Add<HorarioPrestador>(new HorarioPrestadorMetadata());
            modelBuilder.Configurations.Add<Especialidad>(new EspecialidadMetadata());
            modelBuilder.Configurations.Add<Establecimiento>(new EstablecimientoMetadata());
            modelBuilder.Configurations.Add<PrestadorEspecialidad>(new PrestadorEspecialidadMetadata());
            modelBuilder.Configurations.Add<Localidad>(new LocalidadMetadata());
            modelBuilder.Configurations.Add<PrestadorEstablecimiento>(new PrestadorEstablecimientoMetadata());
            modelBuilder.Configurations.Add<Prestador>(new PrestadorMetadata());
            #endregion
        }

        public override Task<int> SaveChangesAsync()
        {

            foreach (var entidad in ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Deleted
                            && x.OriginalValues.PropertyNames
                                .Any(p => p.Contains("EstaEliminado"))))
            {
                entidad.State = EntityState.Unchanged;
                entidad.CurrentValues["EstaEliminado"] = (Int16)1;
            }

            return base.SaveChangesAsync();
        }

        #region DbSet
        public DbSet<Dia> Dias { get; set; }
        public DbSet<DiaHorario> DiaHorarios { get; set; }
        public DbSet<Prestador> Prestadores { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<PrestadorEspecialidad> PrestadorEspecialidades { get; set; }
        public DbSet<HorarioPrestador> HorarioPrestadores { get; set; }
        public DbSet<PrestadorEstablecimiento> PrestadorEstablecimientos { get; set; }
        public DbSet<Establecimiento> Establecimientos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }

        #endregion
    }
}
