using System;
using System.Collections.Generic;
using System.Text;
using Galeno.Infraestructura.Repositorio;

namespace Galeno.Dominio.Entidades
{
    public class PrestadorEspecialidad : EntityBase
    {
        public long IdPrestador { get; set; }
        public long IdEspecialidad { get; set; }

        public virtual ICollection<PrestadorEstablecimiento> PrestadorEstablecimientos { get; set; }
        public virtual Especialidad Especialidad { get; set; }
        public virtual Prestador Prestador { get; set; }
    }
}
