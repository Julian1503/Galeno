using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galeno.Interces.HorarioPrestador.DTOs;

namespace Galeno.Interces.HorarioPrestador
{
    public interface IHorarioPrestadorServicio
    {
      Task<IEnumerable<HorarioPrestadorDto>> ObtenerTodos();
      Task<IEnumerable<HorarioPrestadorDto>> ObtenerPorFiltro(long profesionalId, long establecimientoId, long especialidadId);
        //Task<long> Create(long idprestador, long idestablecimiento, long idespecialidad);
    }
}
