using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.Ef;
using ZeroHunger.Ef.Models;

namespace Zero_Hunger.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ZHContext();
            var cr = db.Distribution.ToList();
            return View(cr);
        }
        
        public ActionResult DistributionList()
        {
            var db = new ZHContext();
            var di = db.Distribution.ToList();
            return View(di);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Distribution model)
        {
            var db = new ZHContext();
            db.Distribution.Add(model);
            db.SaveChanges();
            return RedirectToAction("DistributionList");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new ZHContext();
            var di = (from d in db.Distribution where d.DId == id select d).SingleOrDefault();
            return View(di);
        }
        [HttpPost]
        public ActionResult Edit(Distribution model)
        {
            var db = new ZHContext();
            var di = (from d in db.Distribution where d.DId == model.DId select d).SingleOrDefault();
            db.Entry(di).CurrentValues.SetValues(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var db = new ZHContext();
            var dlt = (from di in db.Distribution where di.DId == id select di).SingleOrDefault();
            db.Distribution.Remove(dlt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var db = new ZHContext();
            var di = (from d in db.Distribution where d.DId == id select d).SingleOrDefault();
            return View(di);
        }
    }
}