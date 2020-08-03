using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Galeno.AutoMapper;
using Galeno.Dominio.Base;
using Galeno.Dominio.Extension;
using Galeno.Interces.HorarioPrestador;
using Galeno.Interces.HorarioPrestador.DTOs;

namespace Galenort.Implementacion.HorarioPrestador
{
    public class HorarioPrestadorServicio : IHorarioPrestadorServicio
    {
        private readonly IMapper _mapper;
        private readonly IRepositorio<Galeno.Dominio.Entidades.HorarioPrestador> _repositorio;

        public HorarioPrestadorServicio(IRepositorio<Galeno.Dominio.Entidades.HorarioPrestador> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x => x.AddProfile<MapperProfile>());
            _mapper = config.CreateMapper();
        }

        public async Task<IEnumerable<HorarioPrestadorDto>> ObtenerTodos()
        {
            try
            {
                var result = await _repositorio.GetAll(x => x.OrderBy(y => y.HoraInicio),
                    x => x.Include(y => y.PrestadorEstablecimiento.Establecimiento)
                        .Include(y => y.PrestadorEstablecimiento.PrestadorEspecialidad.Especialidad)
                        .Include(y => y.PrestadorEstablecimiento.Establecimiento.Localidad)
                        .Include(y => y.PrestadorEstablecimiento.PrestadorEspecialidad.Prestador)
                        .Include(y => y.DiaHorarios)
                        .Include(y => y.DiaHorarios.Select(z => z.Dia))
                );
                return _mapper.Map<IEnumerable<HorarioPrestadorDto>>(result);
            }
            catch(Exception e)
            {
                return null;
            }
        
        }

        public async Task<IEnumerable<HorarioPrestadorDto>> ObtenerPorFiltro(long profesionalId, long establecimientoId, long especialidadId)
        {
            Expression<Func<Galeno.Dominio.Entidades.HorarioPrestador, bool>> exp = x => true;

            if (establecimientoId != 0)
            {
                exp = exp.And(x => x.PrestadorEstablecimiento.IdEstablecimiento == establecimientoId);
            }

            if (profesionalId != 0)
            {
                exp = exp.And(x => x.PrestadorEstablecimiento.PrestadorEspecialidad.IdPrestador == profesionalId);
            }

            if (especialidadId != 0)
            {
                exp = exp.And(x => x.PrestadorEstablecimiento.PrestadorEspecialidad.IdEspecialidad == especialidadId);
            }

            var result = await _repositorio.GetByFilter(exp, x => x.OrderBy(y => y.HoraInicio),
            x => x.Include(y => y.PrestadorEstablecimiento.Establecimiento)
                .Include(y => y.PrestadorEstablecimiento.PrestadorEspecialidad.Especialidad)
                .Include(y => y.PrestadorEstablecimiento.Establecimiento.Localidad)
                .Include(y => y.PrestadorEstablecimiento.PrestadorEspecialidad.Prestador)
                .Include(y => y.DiaHorarios.Select(z => z.Dia)));
            return _mapper.Map<IEnumerable<HorarioPrestadorDto>>(result);
        }
    }
}
