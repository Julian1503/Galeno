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
        private IHorarioPrestadorServicio _horario;
        private IMapper _mapper;

        public HomeController(IHorarioPrestadorServicio horario)
        {
            _horario = horario;
            var config = new MapperConfiguration(x => x.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public async Task<ActionResult> CentroAtencion()
        {
            
            var horarios = _mapper.Map<IEnumerable<HorarioPrestadorViewModel>>(await _horario.ObtenerTodos());

            return View(horarios);


            //var pageNumber = (page ?? 1);

            //ViewBag.FilterValue = cadenaBuscar;

            //var _prestador = await _prestadorServicio.Obtener(prestador, cadenaBuscar, establecimientoBuscar);

            //return View(new CentroAtencionViewModel
            //{

            //    Centros = await _prestador
            //        .OrderByDescending(x => x.FechaDesde)
            //        .Select(s => new CentroAtencionViewModel
            //        {
            //            CentroAtencionId = s.Id,
            //            Prestador = s.Prestador,
            //            Horario = s.Horario.ToShortDateString(),
            //            Dias = s.Dias.ToShortDateString(),
            //            Establecimiento = s.Establecimiento,
            //        }).ToPagedListAsync(pageNumber, 10)
            //});

            return View();
        }
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