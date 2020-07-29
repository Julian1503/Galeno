using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galeno.Interces.PrestadorEstablecimiento.DTOs;

namespace Galeno.Interces.PrestadorEstablecimiento
{
    public interface IPrestadorEstablecimientoServicio
    {
        Task<long> Create(PrestadorEstablecimientoDto prestadorEspecialidad);
        Task<IEnumerable<PrestadorEstablecimientoDto>> GetAll();
        Task<PrestadorEstablecimientoDto> GetById(long id);
        Task Update(PrestadorEstablecimientoDto prestadorEspecialidad, long id);
        Task Delete(long id);
    }
}
