using Microsoft.AspNetCore.Mvc;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace SistemaWebMisRecetas.Controllers
{
    public class RecetaController : Controller
    {
        private readonly RecetaContext context;

        public RecetaController(RecetaContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var recetas = context.Recetas.ToList();
            return View(recetas);
        }

       [HttpGet]
       public ActionResult Create()
       {
          Receta receta = new Receta();
          return View("Register", receta);
       }

       [HttpPost]
        public ActionResult Create(Receta recetas)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(recetas);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recetas);
        }

        [HttpGet]
       public ActionResult Details(int id)
       {
            Receta receta = TraerUna(id);
            if (receta == null)
               {
                  return NotFound();
               }
            else
            {
                return View("detalle", receta);
            }
       }
      private Receta TraerUna(int id)
      {
          return context.Recetas.Find(id);
      }
    }
}
