using System;
using System.Collections.Generic;
using System.Text;
using Galeno.Interces.Especialidad.DTOs;
using Galeno.Interces.Prestador.DTOs;

namespace Galeno.Interces.PrestadorEspecialidad.DTOs
{
   public class PrestadorEspecialidadDto : DtoBase
    {
        public long IdPrestador { get; set; }
        public long IdEspecialidad { get; set; }

        public PrestadorDto Prestador { get; set; }
        public EspecialidadDto Especialidad { get; set; }
    }
}
