using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalenortWebApp.Models
{
    public class HorarioPrestadorModel
    {
        public IEnumerable<string> Dias { get; set; }
        public string Prestador { get; set; }
        public EstablecimientoModel Establecimiento { get; set; }
        public string Especialidad { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
    }
}
