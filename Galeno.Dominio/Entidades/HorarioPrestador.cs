using System;
using System.Collections.Generic;
using System.Text;
using Galeno.Infraestructura.Repositorio;

namespace Galeno.Dominio.Entidades
{
    public class HorarioPrestador : EntityBase
    {
        public long IdPrestadorEstablecimiento { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        public virtual PrestadorEstablecimiento PrestadorEstablecimiento { get; set; }
        public virtual ICollection<DiaHorario> DiaHorarios { get; set; }

    }
}
