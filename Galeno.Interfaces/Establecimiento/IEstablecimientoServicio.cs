using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galeno.Interces.Establecimiento.DTOs;

namespace Galeno.Interces.Establecimiento
{
   public interface IEstablecimientoServicio
   {
       Task<IEnumerable<EstablecimientoDto>> ObtenerTodos();
       Task<EstablecimientoDto> GetById(long id);
       Task<IEnumerable<EstablecimientoDto>> GetByFilter(string cadena);
       Task Create(EstablecimientoDto establecimiento);
       Task Delete(long id);
       Task Update(EstablecimientoDto establecimiento,long id);
    }
}
