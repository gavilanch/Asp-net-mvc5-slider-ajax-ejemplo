using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModuloAjax.Controllers
{
    public class HomeController : Controller
    {
        private List<Persona> _personas;

        public HomeController()
        {
        
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


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public PartialViewResult CambioSlider(int min, int max)
        {
            using (ModuloAjaxApplicationDbContext db = new ModuloAjaxApplicationDbContext())
            {
                var query = db.Personas.Where(x => x.Edad >= min);
                if (max < 61)
                {
                    query = query.Where(x => x.Edad <= max);
                }
                
                var personas = query.ToList();
                
                return PartialView("_personas", personas);
            }
        }
    }







    //public class Persona
    //{
    //    public string Nombre { get; set; }
    //    public int Edad { get; set; }
    //    public int Altura { get; set; }
    //    public int Peso { get; set; }
    //}

}