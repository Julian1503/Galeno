using AutoMapper;
using Galeno.AutoMapper;
using Galeno.Dominio.Base;
using Galeno.Interces.Localidad;
using Galeno.Interces.Localidad.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Galenort.Implementacion.Localidad
{
    public class LocalidadServicio : ILocalidadServicio
    {
        private readonly IRepositorio<Galeno.Dominio.Entidades.Localidad> _repositorio;
        private readonly IMapper _mapper;

        public LocalidadServicio(IRepositorio<Galeno.Dominio.Entidades.Localidad> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x => x.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }

        public async Task Create(LocalidadDto localidad)
        {
            var _localidad = _mapper.Map<Galeno.Dominio.Entidades.Localidad>(localidad);
            await _repositorio.Add(_localidad);
        }

        public async Task<IEnumerable<LocalidadDto>> GetAll()
        {
            var _localidades = await _repositorio.GetAll();
            return _mapper.Map<IEnumerable<LocalidadDto>>(_localidades);
        }

        public async Task<LocalidadDto> GetById(long id)
        {
            var _localidades = await _repositorio.GetById(id);
            return _mapper.Map<LocalidadDto>(_localidades);
        }

        public async Task Update(LocalidadDto localidad, long id)
        {
            var _localidades = _mapper.Map<Galeno.Dominio.Entidades.Localidad>(localidad);
            _localidades.Id = id;
            await _repositorio.Update(_localidades);

        }

        public async Task Delete(long id)
        {
            await _repositorio.Delete(id);
        }
    }
}
