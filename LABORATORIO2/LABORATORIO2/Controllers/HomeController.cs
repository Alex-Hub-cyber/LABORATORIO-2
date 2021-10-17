using LABORATORIO2.Data;
using LABORATORIO2.Dominio;
using LABORATORIO2.Models;
using LABORATORIO2.Repositorio;
using LABORATORIO2.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static LABORATORIO2.Repositorio.AlmacenPersonaRepositorio;

namespace LABORATORIO2.Controllers
{
    public class HomeController : Controller
    {
        //Inyeccion
        private readonly ILogger<HomeController> _logger;
        private IAlmacenPersona Almacenamiento;
        public HomeController(ILogger<HomeController> logger,IAlmacenPersona almacenPersona)
        {
            this.Almacenamiento = almacenPersona;
            _logger = logger;
        }



        public IActionResult Index()
        {

            AlmacenPersona almacen = new AlmacenPersona();
            almacen.NombrePersona = "Jose";
            almacen.EdadPersona = 20;
            almacen.DescripcionPersona = "Alumno";
            Almacenamiento.Insertar(almacen);


            return View();
        }
   
    
       
        public IActionResult GuardarInformacion()
        {
            return View();
        }
        public IActionResult MostrarInformacion()
        {


            return View();
        }

        public IActionResult GetAll()
        {
            var dandoFormatoJson = Almacenamiento.ListarPersonas();
            return Json(new { data = dandoFormatoJson });
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

