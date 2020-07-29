using System;
using System.Collections.Generic;
using System.Text;
using Galeno.Interces.Establecimiento.DTOs;
using Galeno.Interces.Prestador.DTOs;
using Galeno.Interces.PrestadorEspecialidad.DTOs;

namespace Galeno.Interces.PrestadorEstablecimiento.DTOs
{
    public class PrestadorEstablecimientoDto : DtoBase
    {
        public long IdPrestadorEspecialidad { get; set; }
        public long IdEstablecimiento { get; set; }
        public PrestadorEspecialidadDto PrestadorEspecialidad { get; set; }
        public EstablecimientoDto Establecimiento { get; set; }
    }
}
