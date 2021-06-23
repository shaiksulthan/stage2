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
    public class ClsSkillsController : Controller
    {
        private AppDBContext db = new AppDBContext();

        // GET: ClsSkills
        public ActionResult Index()
        {
            var tblSkills = db.tblSkills.Include(c => c.ClsEmployee);
            return View(tblSkills.ToList());
        }

        // GET: ClsSkills/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClsSkill clsSkill = db.tblSkills.Find(id);
            if (clsSkill == null)
            {
                return HttpNotFound();
            }
            return View(clsSkill);
        }

        // GET: ClsSkills/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.tblEmployees, "EmpID", "FirstName");
            return View();
        }

        // POST: ClsSkills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SkillId,EmployeeID,SkillName,Role,ExperienceInYears")] ClsSkill clsSkill)
        {
            if (ModelState.IsValid)
            {
                db.tblSkills.Add(clsSkill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.tblEmployees, "EmpID", "FirstName", clsSkill.EmployeeID);
            return View(clsSkill);
        }

        // GET: ClsSkills/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClsSkill clsSkill = db.tblSkills.Find(id);
            if (clsSkill == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.tblEmployees, "EmpID", "FirstName", clsSkill.EmployeeID);
            return View(clsSkill);
        }

        // POST: ClsSkills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SkillId,EmployeeID,SkillName,Role,ExperienceInYears")] ClsSkill clsSkill)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clsSkill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.tblEmployees, "EmpID", "FirstName", clsSkill.EmployeeID);
            return View(clsSkill);
        }

        // GET: ClsSkills/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClsSkill clsSkill = db.tblSkills.Find(id);
            if (clsSkill == null)
            {
                return HttpNotFound();
            }
            return View(clsSkill);
        }

        // POST: ClsSkills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClsSkill clsSkill = db.tblSkills.Find(id);
            db.tblSkills.Remove(clsSkill);
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
