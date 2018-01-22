using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using third.Models;

namespace third.Controllers
{
    public class EmployeesCategoriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EmployeesCategories
        public ActionResult Index()
        {
            return View(db.EmployeesCategories.ToList());
        }

        // GET: EmployeesCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeesCategories employeesCategories = db.EmployeesCategories.Find(id);
            if (employeesCategories == null)
            {
                return HttpNotFound();
            }
            return View(employeesCategories);
        }

        // GET: EmployeesCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name")] EmployeesCategories employeesCategories)
        {
            if (ModelState.IsValid)
            {
                db.EmployeesCategories.Add(employeesCategories);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeesCategories);
        }

        // GET: EmployeesCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeesCategories employeesCategories = db.EmployeesCategories.Find(id);
            if (employeesCategories == null)
            {
                return HttpNotFound();
            }
            return View(employeesCategories);
        }

        // POST: EmployeesCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name")] EmployeesCategories employeesCategories)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeesCategories).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeesCategories);
        }

        // GET: EmployeesCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeesCategories employeesCategories = db.EmployeesCategories.Find(id);
            if (employeesCategories == null)
            {
                return HttpNotFound();
            }
            return View(employeesCategories);
        }

        // POST: EmployeesCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeesCategories employeesCategories = db.EmployeesCategories.Find(id);
            db.EmployeesCategories.Remove(employeesCategories);
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
