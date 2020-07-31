using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galeno.Interces.Prestador.DTOs;

namespace Galeno.Interces.Prestador
{
    public interface IPrestadorServicio
    {
        Task<IEnumerable<PrestadorDto>> GetAll();
       Task<PrestadorDto> GetById(long id);
       Task<IEnumerable<PrestadorDto>> GetByFilter(string cadena);
       Task<long> Create(PrestadorDto prestador);
        Task Delete(long id);
        Task Update(PrestadorDto prestador,long id);
    }
}
