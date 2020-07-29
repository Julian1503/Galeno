using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galeno.Interces.PrestadorEspecialidad.DTOs;

namespace Galeno.Interces.PrestadorEspecialidad
{
    public interface IPrestadorEspecialidadServicio
    {
        Task<long> Create(PrestadorEspecialidadDto prestadorEspecialidad);
        Task<IEnumerable<PrestadorEspecialidadDto>> GetAll();
        Task<PrestadorEspecialidadDto> GetById(long id);
        Task Update(PrestadorEspecialidadDto prestadorEspecialidad,long id);
        Task Delete(long id);
    }
}
