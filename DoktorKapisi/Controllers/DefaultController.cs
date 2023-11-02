using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoktorKapisi.Models.Entity;

namespace DoktorKapisi.Controllers
{
    public class DefaultController : Controller
    {
        DoktorKapisiEntities db = new DoktorKapisiEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }

        public ActionResult RandevuAl()
        {
            return View();
        }

        public ActionResult DoktorMusunuz()
        {
            return View();
        }
        public ActionResult Giris()
        {
            return View();
        }
    }
}