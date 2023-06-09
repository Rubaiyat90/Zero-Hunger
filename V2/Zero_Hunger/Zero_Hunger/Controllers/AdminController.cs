﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.Ef;
using ZeroHunger.Ef.Models;

namespace Zero_Hunger.Controllers
{
    public class AdminController : Controller
    {
        
        public ActionResult Index()
        {
            var db = new ZHContext();
            var emp = db.Employees.ToList();
            return View(emp);

        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employees model)
        {
            var db = new ZHContext();
            db.Employees.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id) 
        {
            var db = new ZHContext();
            var emp = (from e in db.Employees where e.EmployeeId == id select e).SingleOrDefault();
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employees model)
        {
            var db = new ZHContext();
            var emp = (from e in db.Employees where e.EmployeeId==model.EmployeeId select e).SingleOrDefault();
            db.Entry(emp).CurrentValues.SetValues(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var db = new ZHContext();
            var dlt = (from emp in db.Employees where emp.EmployeeId == id select emp).SingleOrDefault();
            db.Employees.Remove(dlt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult RequestList()
        {
            var db = new ZHContext();
            var emp = db.CollectRequests.ToList();
            return View(emp);

        }
        [HttpGet]
        public ActionResult AssignEmployee(int id)
        {
            var db = new ZHContext();
            var emp = (from e in db.CollectRequests where e.CrId == id select e).SingleOrDefault();
            return View(emp);
        }
        [HttpPost]
        public ActionResult AssignEmployee(CollectRequests model)
        {
            var db = new ZHContext();
            var emp = (from e in db.CollectRequests where e.CrId == model.CrId select e).SingleOrDefault();
            db.Entry(emp).CurrentValues.SetValues(model);
            db.SaveChanges();
            return RedirectToAction("Assigned");
        }
        public ActionResult Assigned()
        {
            var db = new ZHContext();
            var emp = db.CollectRequests.ToList();
            return View(emp);

        }

    }
}