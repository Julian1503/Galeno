using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Galeno.AutoMapper;
using Galeno.Dominio.Base;
using Galeno.Interces.Especialidad;
using Galeno.Interces.Especialidad.DTOs;


namespace Galenort.Implementacion.Especialidad
{
    public class EspecialidadServicio : IEspecialidadServicio
    {
        private readonly IRepositorio<Galeno.Dominio.Entidades.Especialidad> _repositorio;
        private readonly IMapper _mapper;

        public EspecialidadServicio(IRepositorio<Galeno.Dominio.Entidades.Especialidad> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x => x.AddProfile<MapperProfile>());
            _mapper = config.CreateMapper();
        }

        public async Task<IEnumerable<EspecialidadDto>> ObtenerTodos()
        {
            var result = await _repositorio.GetAll();
            return _mapper.Map<IEnumerable<EspecialidadDto>>(result);
        }

        public async Task<EspecialidadDto> GetById(long id)
        {
            var especialidad = await _repositorio.GetById(id);
            return _mapper.Map<EspecialidadDto>(especialidad);
        }

        public async Task Create(EspecialidadDto especialidad)
        {
            var _especialidad = _mapper.Map<Galeno.Dominio.Entidades.Especialidad>(especialidad);
            await _repositorio.Add(_especialidad);
        }

        public async Task Update(EspecialidadDto especialidad,long id)
        {
            var _especialidad = _mapper.Map<Galeno.Dominio.Entidades.Especialidad>(especialidad);
            _especialidad.Id = id;
            await _repositorio.Update(_especialidad);
        }
        public async Task Delete(long id)
        {
            await _repositorio.Delete(id);
        }

    }
}
