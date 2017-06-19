using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaAcademico.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new SistemaAcademico.DataModel.AcademicSystemContext())
            {
                ViewModels.IndexViewModel Model = new ViewModels.IndexViewModel();
                Model.OpcionesDeMenu = context.OpcionesDelMenu.ToList();
                return View(Model);
            }

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
    }
}