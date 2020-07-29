using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galeno.Dominio.Base;
using Galeno.Dominio.Entidades;
using Galeno.Dominio.Repositorio;
using Galeno.Interces.Especialidad;
using Galeno.Interces.Establecimiento;
using Galeno.Interces.HorarioPrestador;
using Galeno.Interces.Prestador;
using Galeno.Interces.PrestadorEspecialidad;
using Galeno.Interces.PrestadorEstablecimiento;
using Galenort.Implementacion.Especialidad;
using Galenort.Implementacion.Establecimiento;
using Galenort.Implementacion.HorarioPrestador;
using Galenort.Implementacion.Prestador;
using Galenort.Implementacion.PrestadorEspecialidad;
using Galenort.Implementacion.PrestadorEstablecimiento;
using Unity;

namespace Galeno.IoC
{
   public static class Injection 
    {
        public static void InyectorDepenendencias(UnityContainer container)
        {
            container.RegisterType<IEspecialidadServicio, EspecialidadServicio>();
            container.RegisterType<IRepositorio<Especialidad>, Repositorio<Especialidad>>();

            container.RegisterType<IHorarioPrestadorServicio, HorarioPrestadorServicio>();
            container.RegisterType<IRepositorio<HorarioPrestador>, Repositorio<HorarioPrestador>>();

            container.RegisterType<IEstablecimientoServicio, EstablecimientoServicio>();
            container.RegisterType<IRepositorio<Establecimiento>, Repositorio<Establecimiento>>();

            container.RegisterType<IPrestadorServicio, PrestadorServicio>();
            container.RegisterType<IRepositorio<Prestador>, Repositorio<Prestador>>();

            container.RegisterType<IPrestadorEspecialidadServicio, PrestadorEspecialidadServicio>();
            container.RegisterType<IRepositorio<PrestadorEspecialidad>, Repositorio<PrestadorEspecialidad>>();

            container.RegisterType<IPrestadorEstablecimientoServicio, PrestadorEstablecimientoServicio>();
            container.RegisterType<IRepositorio<PrestadorEstablecimiento>, Repositorio<PrestadorEstablecimiento>>();
        }
    }
}
