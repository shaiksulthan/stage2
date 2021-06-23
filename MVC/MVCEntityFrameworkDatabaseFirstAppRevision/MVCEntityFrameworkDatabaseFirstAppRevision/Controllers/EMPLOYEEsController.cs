using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCEntityFrameworkDatabaseFirstAppRevision;

namespace MVCEntityFrameworkDatabaseFirstAppRevision.Controllers
{
    public class EMPLOYEEsController : Controller
    {
        private CTSDATABASEEntities1 db = new CTSDATABASEEntities1();

        // GET: EMPLOYEEs
        public ActionResult Index()
        {
            var eMPLOYEEs = db.EMPLOYEEs.Include(e => e.DEPARTMENT);
            return View(eMPLOYEEs.ToList());
        }

        // GET: EMPLOYEEs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
            if (eMPLOYEE == null)
            {
                return HttpNotFound();
            }
            return View(eMPLOYEE);
        }

        // GET: EMPLOYEEs/Create
        public ActionResult Create()
        {
            ViewBag.DEPTID = new SelectList(db.DEPARTMENTs, "DEPTID", "DEPTNAME");
            return View();
        }

        // POST: EMPLOYEEs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EMPLOYEE eMPLOYEE)
        {
            //[Bind(Include = "EMPID,EMPNAME,EMPDESG,DEPTID,SALARY")]
            if (ModelState.IsValid)
            {
                db.EMPLOYEEs.Add(eMPLOYEE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DEPTID = new SelectList(db.DEPARTMENTs, "DEPTID", "DEPTNAME", eMPLOYEE.DEPTID);
            return View(eMPLOYEE);
        }

        // GET: EMPLOYEEs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
            if (eMPLOYEE == null)
            {
                return HttpNotFound();
            }
            ViewBag.DEPTID = new SelectList(db.DEPARTMENTs, "DEPTID", "DEPTNAME", eMPLOYEE.DEPTID);
            return View(eMPLOYEE);
        }

        // POST: EMPLOYEEs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EMPID,EMPNAME,EMPDESG,DEPTID,SALARY")] EMPLOYEE eMPLOYEE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eMPLOYEE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DEPTID = new SelectList(db.DEPARTMENTs, "DEPTID", "DEPTNAME", eMPLOYEE.DEPTID);
            return View(eMPLOYEE);
        }

        // GET: EMPLOYEEs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
            if (eMPLOYEE == null)
            {
                return HttpNotFound();
            }
            return View(eMPLOYEE);
        }

        // POST: EMPLOYEEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
            db.EMPLOYEEs.Remove(eMPLOYEE);
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
