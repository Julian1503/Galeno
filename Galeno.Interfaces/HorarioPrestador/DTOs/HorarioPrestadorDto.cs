using Galeno.Interces.DiaHorario.DTOs;
using Galeno.Interces.PrestadorEstablecimiento.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Galeno.Interces.HorarioPrestador.DTOs
{
    public class HorarioPrestadorDto : DtoBase
    {
        public long IdPrestadorEstablecimiento { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string Horario => HoraFin == new TimeSpan(0,0,0) || HoraInicio == new TimeSpan(0, 0, 0) ? "" : $"{HoraInicio.ToString(@"hh\:mm")} a {HoraFin.ToString(@"hh\:mm")}";
        private string _dias = "";
        public string Dias
        {
            get
            {
                if (DiaHorarios.Count() == 1)
                {
                    return $"{DiaHorarios.First().Dia.Descripcion}";
                }
                if (DiaHorarios != null)
                {
                    foreach (var i in DiaHorarios)
                    {
                        if (!i.Dia.Descripcion.Contains("Lunes a viernes") && !i.Dia.Descripcion.Contains("Sujeto a acuerdo previo con el especialista"))
                        {
                            _dias += i.Dia.Descripcion;
                        }
                        if (DiaHorarios.Last() == i) return _dias;
                        _dias += " - ";
                    }
                }

                return "";
            }
        }
        public IEnumerable<DiaHorarioDto> DiaHorarios { get; set; }
        public PrestadorEstablecimientoDto PrestadorEstablecimiento { get; set; }
    }
}
