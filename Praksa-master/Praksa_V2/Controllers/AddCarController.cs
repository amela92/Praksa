using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Praksa_V2.Controllers
{
    public class AddCarController : Controller
    {
        CarsEntities1 entiti = new CarsEntities1();
        //
        // GET: /AddCar/
        public ActionResult Index()
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
	}
}