using System;
using System.Collections.Generic;
using System.Text;

namespace Galeno.Interces.Prestador.DTOs
{
     public class PrestadorDto :DtoBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string ApYNom => $"{Apellido} {Nombre}";
    }
}
