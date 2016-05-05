using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        //Prikazivanje vozila
        public ActionResult Cars()
        {
            return View(entiti.Cars.ToList());
        }

        //Prikazivanje pozecije
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

        [HttpPost]
        public ActionResult AddCar(Cars c)
        {
            using (entiti)
            {
                entiti.Cars.Add(c);
                entiti.SaveChanges();
            }
            return RedirectToAction("AddCar");
        }

        //Dodavanje pozicije vozila
        //public ActionResult Addposition()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult Addposition(Positions poz)
        {
            using (entiti)
            {
                try
                {
                    entiti.Positions.Add(poz);
                    entiti.SaveChanges();

                    return Json(new { success = true, responseText= "Your message successfuly sent!"}, JsonRequestBehavior.AllowGet);
                
                    //return RedirectToAction("Addposition");
                }
                catch (Exception)
                {
                    HttpResponseBase response = Response;
                    response.StatusCode = 500;
                    return Json(new { success = false, responseText = "Nije uspjesno dodat u bazu." }, JsonRequestBehavior.AllowGet);
                }
                //return RedirectToAction("Addposition");
            }
        }

    

        public ActionResult dohvatiZadanjuPutanju(int? id)
        {
            var podaci = entiti.Positions.Where(p => p.id == id).ToList();
            int zadnjiS = entiti.Positions.Where(e => e.status == "s").Where(e => e.id == id).Max(e => e.id_position);
            int zadnjiP = entiti.Positions.Where(e => e.status == "e").Where(e=>e.id==id).Max(e=>e.id_position);

            List<Positions> lista = new List<Positions>();
            for (int i = zadnjiS; i <= zadnjiP; i++)
            {
                var startnaTacka = entiti.Positions.Where(e => e.id_position == i).First();
                lista.Add(startnaTacka);
               
            }



                //  var podaci = entiti.Positions.Where(p => p.id == id).ToList();
                //  var zadnjiS = entiti.Positions.Where(e => e.status == "s").Where(e=>e.id==id).Max(e=>e.id_position);
                //  var startnaTacka = entiti.Positions.Where(e => e.id_position == zadnjiS).ToList();
                //  //tacke.latitude = entiti.Positions.Where(x => x.status == "s");
                // var krajnjaTacka = entiti.Positions.Where(e => e.id_position>zadnjiS).Where(e=>e.status=="e");
                //// var usputneTacke = entiti.Positions.Where(u => u.id_position > startnaTacka.id_position).ToList();
            return View(lista);

            
            
        }
      

        



    
    }
}