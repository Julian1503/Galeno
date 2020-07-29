using AutoMapper;
using Galeno.AutoMapper;
using Galeno.Dominio.Base;
using Galeno.Interces.DiaHorario;
using Galeno.Interces.DiaHorario.DTOs;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Galenort.Implementacion.DiaHorario
{
    public class DiaHorarioServicio : IDiaHorarioServicio
    {
        private readonly IRepositorio<Galeno.Dominio.Entidades.DiaHorario> _repositorio;
        private readonly IMapper _mapper;

        public DiaHorarioServicio(IRepositorio<Galeno.Dominio.Entidades.DiaHorario> repositorio)
        {
            _repositorio = repositorio;
            var config = new MapperConfiguration(x => x.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }
        public async Task Create(DiaHorarioDto diaHorario)
        {
            var _diaHorario = _mapper.Map<Galeno.Dominio.Entidades.DiaHorario>(diaHorario);
            await _repositorio.Add(_diaHorario);
        }

        public async Task<IEnumerable<DiaHorarioDto>> GetAll()
        {
            {
                var result = await _repositorio.GetAll(x => x.OrderBy(y => y.Dia.Id),
                    x => x.Include(y => y.Dia).Include(y => y.HorarioPrestador));
                return _mapper.Map<IEnumerable<DiaHorarioDto>>(result);
            }
        }

        public async Task<DiaHorarioDto> GetById(long id)
        {
            var diaHorario = await _repositorio.GetById(id);
            return _mapper.Map<DiaHorarioDto>(diaHorario);
        }

        public async Task Update(DiaHorarioDto diaHorario, long id)
        {
            var _diaHorario = _mapper.Map<Galeno.Dominio.Entidades.DiaHorario>(diaHorario);
            _diaHorario.Id = id;
            await _repositorio.Update(_diaHorario);
        }
        public async Task Delete(long id)
        {
            await _repositorio.Delete(id);
        }
    }
}
