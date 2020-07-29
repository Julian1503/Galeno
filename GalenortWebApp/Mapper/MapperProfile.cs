using AutoMapper;
using Galeno.Interces.Dia.DTOs;
using Galeno.Interces.DiaHorario.DTOs;
using Galeno.Interces.Especialidad.DTOs;
using Galeno.Interces.Establecimiento.DTOs;
using Galeno.Interces.HorarioPrestador.DTOs;
using Galeno.Interces.Prestador.DTOs;
using Galeno.Interces.PrestadorEspecialidad.DTOs;
using Galeno.Interces.PrestadorEstablecimiento.DTOs;
using GalenortWebApp.Models;
using System.Linq;

namespace GalenortWebApp.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<DiaModel, DiaDto>().ReverseMap();
            CreateMap<PrestadorModel, PrestadorDto>().ReverseMap();
            CreateMap<EstablecimientoModel, EstablecimientoDto>().ReverseMap().ForMember(x => x.Localidad, y => y.MapFrom(z => z.Localidad.Descripcion));
            CreateMap<EspecialidadModel, EspecialidadDto>().ReverseMap();
            CreateMap<HorarioPrestadorModel, HorarioPrestadorDto>()
                .ReverseMap()
                .ForMember(x => x.Dias, y => y.MapFrom(z => z.DiaHorarios.Select(q => q.Dia.Descripcion)))
                .ForMember(x => x.Prestador, y => y.MapFrom(z => z.PrestadorEstablecimiento.PrestadorEspecialidad.Prestador.ApYNom))
                .ForMember(x => x.Especialidad, y => y.MapFrom(z => z.PrestadorEstablecimiento.PrestadorEspecialidad.Especialidad.Descripcion))
                .ForMember(x => x.Establecimiento, y => y.MapFrom(z => z.PrestadorEstablecimiento.Establecimiento));

            CreateMap<PrestadorEstablecimientoModel, PrestadorEstablecimientoDto>().ReverseMap();
            CreateMap<PrestadorEspecialidadModel, PrestadorEspecialidadDto>().ReverseMap();
            CreateMap<DiaHorarioModel, DiaHorarioDto>().ReverseMap();
            CreateMap<DiaModel, DiaDto>();
        }
    }
}