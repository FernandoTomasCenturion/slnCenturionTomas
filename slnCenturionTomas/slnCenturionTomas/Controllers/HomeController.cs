using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebMisRecetas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.P1 = "El desayuno es la primera comida que se consume en el día.";
            ViewBag.P2 = "El nombre deriva del hecho de que uno no come mientras duerme, por lo que al levantarse se encuentra en ayunas, rompiéndose ese ayuno al tomar esta comida (des-ayuno).";
            ViewBag.P3 = "El desayuno es la comida fundamental del día, ya que consumirlo o no, nos afecta de forma notable a corto y a largo plazo.";
            return View();
        }
    }
}
