using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BBMIS.Models;

namespace BBMIS.Views
{
    public class MotorsController : Controller
    {
        private BBMISContext db = new BBMISContext();

        // GET: Motors
        public ActionResult Index()
        {
            return View(db.Motor.ToList());
        }

        // GET: Motors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motor motor = db.Motor.Find(id);
            if (motor == null)
            {
                return HttpNotFound();
            }
            return View(motor);
        }

        // GET: Motors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Motors/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MotorID,Name")] Motor motor)
        {
            if (ModelState.IsValid)
            {
                db.Motor.Add(motor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(motor);
        }

        // GET: Motors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motor motor = db.Motor.Find(id);
            if (motor == null)
            {
                return HttpNotFound();
            }
            return View(motor);
        }

        // POST: Motors/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MotorID,Name")] Motor motor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(motor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motor);
        }

        // GET: Motors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motor motor = db.Motor.Find(id);
            if (motor == null)
            {
                return HttpNotFound();
            }
            return View(motor);
        }

        // POST: Motors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Motor motor = db.Motor.Find(id);
            db.Motor.Remove(motor);
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
