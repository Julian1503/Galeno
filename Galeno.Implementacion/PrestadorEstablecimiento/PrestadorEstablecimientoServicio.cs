using AutoMapper;
using Galeno.AutoMapper;
using Galeno.Dominio.Base;
using Galeno.Interces.PrestadorEstablecimiento;
using Galeno.Interces.PrestadorEstablecimiento.DTOs;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Galenort.Implementacion.PrestadorEstablecimiento
{
    public class PrestadorEstablecimientoServicio : IPrestadorEstablecimientoServicio
    {
        private readonly IRepositorio<Galeno.Dominio.Entidades.PrestadorEstablecimiento> _repositorio;
        private readonly IMapper _mapper;

        public PrestadorEstablecimientoServicio(IRepositorio<Galeno.Dominio.Entidades.PrestadorEstablecimiento> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x => x.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }
        public async Task<long> Create(PrestadorEstablecimientoDto prestadorEstablecimiento)
        {
            var _prestadorEstablecimiento = _mapper.Map<Galeno.Dominio.Entidades.PrestadorEstablecimiento>(prestadorEstablecimiento);
            return await _repositorio.Add(_prestadorEstablecimiento);
        }

        public async Task<IEnumerable<PrestadorEstablecimientoDto>> GetAll()
        {
            var _prestadorEstablecimientoes = await _repositorio.GetAll(
                x => x.OrderBy(y => y.PrestadorEspecialidad.Prestador.Apellido),
                x => x.Include(y => y.Establecimiento).Include(y => y.PrestadorEspecialidad));
            return _mapper.Map<IEnumerable<PrestadorEstablecimientoDto>>(_prestadorEstablecimientoes);
        }

        public async Task<PrestadorEstablecimientoDto> GetById(long id)
        {
            var _prestadorEstablecimiento = await _repositorio.GetById(id, x => x.Include(y => y.Establecimiento).Include(y => y.PrestadorEspecialidad));
            return _mapper.Map<PrestadorEstablecimientoDto>(_prestadorEstablecimiento);
        }

        public async Task Update(PrestadorEstablecimientoDto prestadorEstablecimiento, long id)
        {
            var _prestadorEstablecimiento = _mapper.Map<Galeno.Dominio.Entidades.PrestadorEstablecimiento>(prestadorEstablecimiento);
            _prestadorEstablecimiento.Id = id;
            await _repositorio.Update(_prestadorEstablecimiento);

        }

        public async Task Delete(long id)
        {
            await _repositorio.Delete(id);
        }
    }
}
