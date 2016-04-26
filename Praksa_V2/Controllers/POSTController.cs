using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Praksa_V2.Controllers
{
    public class POSTController : Controller
    {
        CarsEntities1 entiti = new CarsEntities1();
        // GET: /POST/
        [HttpPost]
        public ActionResult post(int? id)
        {
            Positions novaLokacija = entiti.Positions.Find(id);
            return View(entry);
        }

        public IView entry { get; set; }
    }
}