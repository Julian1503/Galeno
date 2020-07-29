using System;
using System.Collections.Generic;
using System.Text;
using Galeno.Infraestructura.Repositorio;

namespace Galeno.Dominio.Entidades
{
    public class Prestador :EntityBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public virtual ICollection<PrestadorEspecialidad> PrestadorEspecialidades { get; set; }
    }

}
