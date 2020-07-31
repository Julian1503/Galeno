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
            CreateMap<PrestadorViewModel, PrestadorDto>().ReverseMap();
            CreateMap<EstablecimientoViewModel, EstablecimientoDto>().ReverseMap().ForMember(x => x.Localidad, y => y.MapFrom(z => z.Localidad.Descripcion));
            CreateMap<EspecialidadViewModel, EspecialidadDto>().ReverseMap();
            CreateMap<HorarioPrestadorViewModel, HorarioPrestadorDto>()
                .ReverseMap()
                .ForMember(x => x.Dias, y => y.MapFrom(z => z.Dias))
                .ForMember(x => x.Prestador, y => y.MapFrom(z => z.PrestadorEstablecimiento.PrestadorEspecialidad.Prestador.ApYNom))
                .ForMember(x => x.Especialidad, y => y.MapFrom(z => z.PrestadorEstablecimiento.PrestadorEspecialidad.Especialidad.Descripcion))
                .ForMember(x=>x.Establecimiento,y=>y.MapFrom(z=>z.PrestadorEstablecimiento.Establecimiento.RazonSocialDireccion))
                .ForMember(x => x.Horario, y => y.MapFrom(z => z.Horario));
        }
    }
}