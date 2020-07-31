using System;
using AutoMapper;
using Galeno.AutoMapper;
using Galeno.Dominio.Base;
using Galeno.Interces.Prestador;
using Galeno.Interces.Prestador.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Galeno.Dominio.Extension;

namespace Galenort.Implementacion.Prestador
{
    public class PrestadorServicio : IPrestadorServicio
    {
        private readonly IRepositorio<Galeno.Dominio.Entidades.Prestador> _repositorio;
        private readonly IMapper _mapper;
        public PrestadorServicio(IRepositorio<Galeno.Dominio.Entidades.Prestador> repositorio)
        {
            var config = new MapperConfiguration(x => x.AddProfile<MapperProfile>());
            _mapper = config.CreateMapper();
            _repositorio = repositorio;
        }

        public async Task<PrestadorDto> GetById(long id)
        {
            var prestador = await _repositorio.GetById(id);
            return _mapper.Map<PrestadorDto>(prestador);
        }

        public async Task<IEnumerable<PrestadorDto>> GetByFilter(string cadena)
        {
            Expression<Func<Galeno.Dominio.Entidades.Prestador, bool>> exp = x => true;
            exp = exp.Or(x => x.Apellido.Contains(cadena));
            exp = exp.Or(x => x.Nombre.Contains(cadena));
            var result = await _repositorio.GetByFilter(exp,orderBy:x=>x.OrderBy(y=>y.Apellido).ThenBy(y=>y.Nombre));
            return _mapper.Map<IEnumerable<PrestadorDto>>(result);
        }

        public async Task<IEnumerable<PrestadorDto>> GetAll()
        {
            var result = await _repositorio.GetAll(orderBy: x => x.OrderBy(y => y.Apellido).ThenBy(y => y.Nombre));
            return _mapper.Map<IEnumerable<PrestadorDto>>(result);
        }

        public async Task<long> Create(PrestadorDto prestador)
        {
            var _prestador = _mapper.Map<Galeno.Dominio.Entidades.Prestador>(prestador);
            return await _repositorio.Add(_prestador);
        }

        public async Task Delete(long id)
        {
            await _repositorio.Delete(id);
        }

        public async Task Update(PrestadorDto prestador, long id)
        {
            var _prestador = _mapper.Map<Galeno.Dominio.Entidades.Prestador>(prestador);
            _prestador.Id = id;
            await _repositorio.Update(_prestador);
        }
    }
}
