using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galeno.Interces.Especialidad.DTOs;

namespace Galeno.Interces.Especialidad
{
    public interface IEspecialidadServicio
    {
        Task<IEnumerable<EspecialidadDto>> ObtenerTodos();
        Task<EspecialidadDto>GetById(long id);
        Task<IEnumerable<EspecialidadDto>> GetByFilter(string cadena);
        Task Create(EspecialidadDto especialidad);
        Task Delete(long id);
        Task Update(EspecialidadDto especialidad,long id);
    }
}
