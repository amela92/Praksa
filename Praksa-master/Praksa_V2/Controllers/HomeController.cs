using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Praksa_V2.Controllers
{
    public class HomeController : Controller
    {
        CarsEntities1 entiti = new CarsEntities1();
        //CarsEntities1 entiteti2 = new CarsEntities1();

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

        public ActionResult podaciPozicije(int? id)
        {
            //Positions pozicije = new Positions();
            //Postions pozicije = Positions.Where(p => p.id == id);
            var podaci = entiti.Positions.Where(p => p.id == id).ToList();
            //Positions podaci = entiteti2.Positions.Find(id);
             //if (podaci != null) { 
                return View(podaci);
             //}
            //return View(kola)
        }

       //Dodavanje auta
        public ActionResult AddCar()
        {
            return View();
        }
        

        public ActionResult AddCar(Cars c)
        {
            using(entiti)
            {
                entiti.Cars.Add(c);
                entiti.SaveChanges();
            }
            return RedirectToAction("AddCar");
        }

        //public ActionResult Addposition()
        //{
        //    ViewBag.str = "1";
        //    return View();
        //}




    
    }
}