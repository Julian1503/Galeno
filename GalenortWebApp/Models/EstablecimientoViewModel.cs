using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalenortWebApp.Models
{
    public class EstablecimientoViewModel
    {
        public long Id { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
    }
}
