using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Galeno.AutoMapper;
using Galeno.Dominio.Base;
using Galeno.Interces.PrestadorEspecialidad;
using Galeno.Interces.PrestadorEspecialidad.DTOs;

namespace Galenort.Implementacion.PrestadorEspecialidad
{
    public class PrestadorEspecialidadServicio : IPrestadorEspecialidadServicio
    {
        private readonly IRepositorio<Galeno.Dominio.Entidades.PrestadorEspecialidad> _repositorio;
        private readonly IMapper _mapper;

        public PrestadorEspecialidadServicio(IRepositorio<Galeno.Dominio.Entidades.PrestadorEspecialidad> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x=>x.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }

        public async Task<long> Create(PrestadorEspecialidadDto prestadorEspecialidad)
        {
            var prest = _mapper.Map<Galeno.Dominio.Entidades.PrestadorEspecialidad>(prestadorEspecialidad);
            return await _repositorio.Add(prest);
        }

        public async Task<IEnumerable<PrestadorEspecialidadDto>> GetAll()
        {
            var presesp =  await _repositorio.GetAll(x => x.OrderBy(y => y.Prestador.Apellido),
                x => x.Include(y => y.Especialidad).Include(y => y.Prestador));
            return _mapper.Map<IEnumerable<PrestadorEspecialidadDto>>(presesp);
        }

        public async Task<PrestadorEspecialidadDto> GetById(long id)
        {
            var presesp =  await _repositorio.GetById(id,
                x => x.Include(y => y.Especialidad).Include(y => y.Prestador));
            return _mapper.Map<PrestadorEspecialidadDto>(presesp);
        }

        public async Task Update(PrestadorEspecialidadDto prestadorEspecialidad,long id)
        {
            var _prestadorEspecialidad = _mapper.Map<Galeno.Dominio.Entidades.PrestadorEspecialidad>(prestadorEspecialidad);
            _prestadorEspecialidad.Id = id;
            await _repositorio.Update(_prestadorEspecialidad);
        }

        public async Task Delete(long id)
        {
            await _repositorio.Delete(id);
        }
    }
}
