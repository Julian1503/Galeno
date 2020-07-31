using System;
using System.Collections.Generic;
using System.Text;
using Galeno.Interces.Localidad.DTOs;

namespace Galeno.Interces.Establecimiento.DTOs
{
   public class EstablecimientoDto :DtoBase
    {
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public LocalidadDto Localidad { get; set; }
        public string RazonSocialDireccion => $"{Direccion} - {Localidad.Descripcion}";

    }
}
