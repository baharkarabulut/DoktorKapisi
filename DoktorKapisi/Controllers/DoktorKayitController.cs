using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using DoktorKapisi.Models.Entity;

namespace DoktorKapisi.Controllers
{
    public class DoktorKayitController : Controller
    {
        // GET: DoktorKayit
        DoktorKapisiEntities db = new DoktorKapisiEntities();
        [HttpGet]
        public ActionResult Kayit()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Kayit(DoktorGiris p)
        {
            db.DoktorGiris.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index","DoktorGiris");
        }
    }
}