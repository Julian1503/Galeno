using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalenortWebApp.Models
{
    public class PrestadorEspecialidadModel
    {
        public PrestadorModel Prestador { get; set; }
        public EspecialidadModel Especialidad { get; set; }
    }
}
