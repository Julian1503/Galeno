using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galeno.Interces.Localidad.DTOs;
using Galeno.Interces.PrestadorEstablecimiento.DTOs;

namespace Galeno.Interces.Localidad
{
    public interface ILocalidadServicio
    {
        Task Create(LocalidadDto localidad);
        Task<IEnumerable<LocalidadDto>> GetAll();
        Task<LocalidadDto> GetById(long id);
        Task Update(LocalidadDto localidad, long id);
        Task Delete(long id);
    }
}
