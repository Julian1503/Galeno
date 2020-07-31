using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalenortWebApp.Models
{
    public class HorarioPrestadorViewModel
    {
        public string Especialidad { get; set; }
        public string Establecimiento { get; set; }
        public string Prestador { get; set; }
        public IEnumerable<string> Dias { get; set; }
        public string Horario { get; set; }
    }
}
