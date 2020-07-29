using System;
using System.Collections.Generic;
using System.Text;
using Galeno.Infraestructura.Repositorio;

namespace Galeno.Dominio.Entidades
{
    public class DiaHorario : EntityBase
    {
        public long IdDia { get; set; }
        public long IdHorarioPrestador { get; set; }

        public virtual Dia Dia { get; set; }
        public virtual HorarioPrestador HorarioPrestador { get; set; }
    }
}
