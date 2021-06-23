using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCEntityFramewrokCodeFirstDemo.Models;

namespace MVCEntityFramewrokCodeFirstDemo.Controllers
{
    public class ClsEmployeesController : Controller
    {
        private AppDBContext db = new AppDBContext();

        // GET: ClsEmployees
        public ActionResult Index()
        {
            return View(db.tblEmployees.ToList());
        }

        // GET: ClsEmployees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClsEmployee clsEmployee = db.tblEmployees.Find(id);
            if (clsEmployee == null)
            {
                return HttpNotFound();
            }
            return View(clsEmployee);
        }

        // GET: ClsEmployees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClsEmployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpID,FirstName,LastName,Password,CellNumber,Email")] ClsEmployee clsEmployee)
        {
            if (ModelState.IsValid)
            {
                db.tblEmployees.Add(clsEmployee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clsEmployee);
        }

        // GET: ClsEmployees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClsEmployee clsEmployee = db.tblEmployees.Find(id);
            if (clsEmployee == null)
            {
                return HttpNotFound();
            }
            return View(clsEmployee);
        }

        // POST: ClsEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpID,FirstName,LastName,Password,CellNumber,Email")] ClsEmployee clsEmployee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clsEmployee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clsEmployee);
        }

        // GET: ClsEmployees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClsEmployee clsEmployee = db.tblEmployees.Find(id);
            if (clsEmployee == null)
            {
                return HttpNotFound();
            }
            return View(clsEmployee);
        }

        // POST: ClsEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClsEmployee clsEmployee = db.tblEmployees.Find(id);
            db.tblEmployees.Remove(clsEmployee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
