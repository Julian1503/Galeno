using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalenortWebApp.Models
{
    public class PrestadorEstablecimientoModel
    {
        public PrestadorEspecialidadModel PrestadorEspecialidad { get; set; }
        public EstablecimientoModel Establecimiento { get; set; }
    }
}
