using System;
using System.Collections.Generic;
using System.Text;
using Galeno.Infraestructura.Repositorio;

namespace Galeno.Dominio.Entidades
{
    public class PrestadorEstablecimiento : EntityBase
    {
        public long IdPrestadorEspecialidad { get; set; }
        public long IdEstablecimiento { get; set; }

        public virtual PrestadorEspecialidad PrestadorEspecialidad { get; set; }
        public virtual Establecimiento Establecimiento { get; set; }
        public virtual ICollection<HorarioPrestador> HorarioPrestadores { get; set; }
    }
}
