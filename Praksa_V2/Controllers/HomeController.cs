using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Praksa_V2.Controllers
{
    public class HomeController : Controller
    {
        CarsEntities entiti = new CarsEntities();

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

        public ActionResult Cars()
        {
            return View(entiti.Cars.ToList());
        }

        public ActionResult CarsPozicija(int? id)
        {
            

            Cars kola = entiti.Cars.Find(id);
            return View(kola);
        }
    }
}