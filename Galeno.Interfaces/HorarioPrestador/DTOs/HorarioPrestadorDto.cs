using System;
using System.Collections.Generic;
using System.Text;
using Galeno.Interces.DiaHorario.DTOs;
using Galeno.Interces.Especialidad.DTOs;
using Galeno.Interces.Establecimiento.DTOs;
using Galeno.Interces.Prestador.DTOs;
using Galeno.Interces.PrestadorEstablecimiento.DTOs;

namespace Galeno.Interces.HorarioPrestador.DTOs
{
    public class HorarioPrestadorDto : DtoBase
    {
        public long IdPrestadorEstablecimiento { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        public IEnumerable<DiaHorarioDto> DiaHorarios { get; set; }
        public PrestadorEstablecimientoDto PrestadorEstablecimiento { get; set; }
    }
}
