using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Galeno.Dominio.Entidades;
using Galeno.Interces.Dia.DTOs;
using Galeno.Interces.DiaHorario.DTOs;
using Galeno.Interces.Especialidad.DTOs;
using Galeno.Interces.Establecimiento.DTOs;
using Galeno.Interces.HorarioPrestador.DTOs;
using Galeno.Interces.Localidad.DTOs;
using Galeno.Interces.Prestador.DTOs;
using Galeno.Interces.PrestadorEspecialidad.DTOs;
using Galeno.Interces.PrestadorEstablecimiento.DTOs;

namespace Galeno.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Dia, DiaDto>().ReverseMap();
            CreateMap<DiaHorario, DiaHorarioDto>().ReverseMap();
            CreateMap<Localidad, LocalidadDto>().ReverseMap();
            CreateMap<Especialidad, EspecialidadDto>().ReverseMap();
            CreateMap<Establecimiento, EstablecimientoDto>().ReverseMap();
            CreateMap<HorarioPrestador, HorarioPrestadorDto>().ReverseMap();
            CreateMap<Prestador, PrestadorDto>().ReverseMap();
            CreateMap<PrestadorEspecialidad, PrestadorEspecialidadDto>().ReverseMap();
            CreateMap<PrestadorEstablecimiento, PrestadorEstablecimientoDto>().ReverseMap();
        }
    }
}
