using System.Collections.Generic;
using Galeno.Infraestructura.Repositorio;

namespace Galeno.Dominio.Entidades
{
    public class Establecimiento : EntityBase
    {
        public string RazonSocial {get; set;}
        public string Direccion { get; set; }
        public long IdLocalidad { get; set; }

        public virtual Localidad Localidad { get; set; }
        public virtual ICollection<PrestadorEstablecimiento> PrestadorEstablecimientos { get; set; }
    }
}
