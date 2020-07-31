using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Galeno.AutoMapper;
using Galeno.Dominio.Base;
using Galeno.Dominio.Extension;
using Galeno.Interces.Establecimiento;
using Galeno.Interces.Establecimiento.DTOs;

namespace Galenort.Implementacion.Establecimiento
{
    public class EstablecimientoServicio : IEstablecimientoServicio
    {
        private readonly IMapper _mapper;

        private readonly IRepositorio<Galeno.Dominio.Entidades.Establecimiento> _repositorio;

        public EstablecimientoServicio(IRepositorio<Galeno.Dominio.Entidades.Establecimiento> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x => x.AddProfile<MapperProfile>());
            _mapper = config.CreateMapper();
        }

        public async Task Create(EstablecimientoDto establecimiento)
        {
            var _establecimiento = _mapper.Map<Galeno.Dominio.Entidades.Establecimiento>(establecimiento);
            await _repositorio.Add(_establecimiento);
        }

        public async Task Delete(long id)
        {
            await _repositorio.Delete(id);
        }

        public async Task<IEnumerable<EstablecimientoDto>> GetByFilter(string cadena)
        {
            Expression<Func<Galeno.Dominio.Entidades.Establecimiento, bool>> exp = x => true;
            exp = exp.And(x => x.RazonSocial.Contains(cadena));
            var result = await _repositorio.GetByFilter(exp, orderBy: x => x.OrderBy(y => y.RazonSocial));
            return _mapper.Map<IEnumerable<EstablecimientoDto>>(result);
        }

        public async Task Update(EstablecimientoDto establecimiento, long id)
        {
            var _establecimiento = _mapper.Map<Galeno.Dominio.Entidades.Establecimiento>(establecimiento);
            _establecimiento.Id = id;
            await _repositorio.Update(_establecimiento);
        }

        public async Task<EstablecimientoDto> GetById(long id)
        {
            var establecimiento = await  _repositorio.GetById(id);
            return _mapper.Map<EstablecimientoDto>(establecimiento);
        }

    public async Task<IEnumerable<EstablecimientoDto>> ObtenerTodos()
        {
            var result = await _repositorio.GetAll(orderBy: x => x.OrderBy(y => y.RazonSocial));
            return _mapper.Map<IEnumerable<EstablecimientoDto>>(result);
        }
    }
}
