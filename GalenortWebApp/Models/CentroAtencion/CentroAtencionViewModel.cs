using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GalenortWebApp.Models.CentroAtencion
{
    public class CentroAtencionViewModel

    {
        public long CentroAtencionId { get; set; }

        public string Horario { get; set; }

        public string Dias { get; set; }

        public string Establecimiento { get; set; }

        public string Prestador { get; set; }

        public int? Page { get; set; }

        public string CadenaBuscar { get; set; }
        public string EspecialidadBuscar { get; set; }

        public IEnumerable<CentroAtencionViewModel> Centros { get; set; }

    }
}