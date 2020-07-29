using System;
using System.Collections.Generic;
using System.Text;
using Galeno.Infraestructura.Repositorio;

namespace Galeno.Dominio.Entidades
{
    public class Localidad : EntityBase
    {
        public string Descripcion { get; set; }

        public virtual ICollection<Establecimiento> Establecimientos { get; set; }
    }
}
