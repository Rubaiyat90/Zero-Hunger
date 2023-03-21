using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.Ef;
using ZeroHunger.Ef.Models;

namespace Zero_Hunger.Controllers
{
    public class ResturantController : Controller
    {
        public ActionResult Index()
        {
            var db = new ZHContext();
            var cr = db.CollectRequests.ToList();
            return View(cr);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CollectRequests model)
        {
            var db = new ZHContext();
            db.CollectRequests.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Food()
        {
            var db = new ZHContext();
            var fd = db.Foods.ToList();
            return View(fd);
        }
    }

    
}