using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Galeno.Interces.Prestador;
using GalenortWebApp.Mapper;
using System.Web.Mvc;
using Galeno.Interces.HorarioPrestador;
using Galeno.Interces.Prestador.DTOs;
using GalenortWebApp.Models;

namespace GalenortWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IHorarioPrestadorServicio _prestador;
        private IMapper _mapper;

        public HomeController(IHorarioPrestadorServicio prestador)
        {
            _prestador = prestador;
            var config = new MapperConfiguration(x => x.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }


        public async Task<ActionResult> Index()
        {
            var a = await _prestador.ObtenerPorFiltro(1,0,0);
            var b = _mapper.Map<IEnumerable<HorarioPrestadorModel>>(a);
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        //public async Task<ActionResult> CentroAtencion(string prestador, int? page, string cadenaBuscar, string establecimientoBuscar)
        //{
        //    var pageNumber = (page ?? 1);

        //    ViewBag.FilterValue = cadenaBuscar;

        //   var _prestador = await _prestadorServicio.Obtener(prestador, cadenaBuscar, establecimientoBuscar);

        //    return View(new CentroAtencionViewModel
        //    {

        //        Centros = await _prestador
        //            .OrderByDescending(x => x.FechaDesde)
        //            .Select(s => new CentroAtencionViewModel
        //            {
        //                CentroAtencionId = s.Id,
        //                Prestador = s.Prestador,
        //                Horario = s.Horario.ToShortDateString(),
        //                Dias = s.Dias.ToShortDateString(),
        //                Establecimiento = s.Establecimiento,
        //            }).ToPagedListAsync(pageNumber, 10)
        //    });
        //}
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Planes()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Afiliado()
        {

            return View();
        }

    }
}