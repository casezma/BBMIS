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
    public class DerivationsController : Controller
    {
        private BBMISContext db = new BBMISContext();

        // GET: Derivations
        public ActionResult Index()
        {
            var derivation = db.Derivation.Include(d => d.CarBuild).Include(d => d.Fuel).Include(d => d.Motor);
            return View(derivation.ToList());
        }

        // GET: Derivations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Derivation derivation = db.Derivation.Find(id);
            if (derivation == null)
            {
                return HttpNotFound();
            }
            return View(derivation);
        }

        // GET: Derivations/Create
        public ActionResult Create()
        {
            ViewBag.Mnemonic_Bodystyle = new SelectList(db.CarBuild, "Mnemonic_Bodystyle", "Mnemonic_Bodystyle");
            ViewBag.FuelID = new SelectList(db.Fuel, "FuelID", "Name");
            ViewBag.MotorID = new SelectList(db.Motor, "MotorID", "Name");
            return View();
        }

        // POST: Derivations/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DerivationID,Description,MotorID,FuelID,Mnemonic_Bodystyle")] Derivation derivation)
        {
            if (ModelState.IsValid)
            {
                db.Derivation.Add(derivation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Mnemonic_Bodystyle = new SelectList(db.CarBuild, "Mnemonic_Bodystyle", "Mnemonic_Vehicle", derivation.Mnemonic_Bodystyle);
            ViewBag.FuelID = new SelectList(db.Fuel, "FuelID", "Name", derivation.FuelID);
            ViewBag.MotorID = new SelectList(db.Motor, "MotorID", "Name", derivation.MotorID);
            return View(derivation);
        }

        // GET: Derivations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Derivation derivation = db.Derivation.Find(id);
            if (derivation == null)
            {
                return HttpNotFound();
            }
            ViewBag.Mnemonic_Bodystyle = new SelectList(db.CarBuild, "Mnemonic_Bodystyle", "Mnemonic_Vehicle", derivation.Mnemonic_Bodystyle);
            ViewBag.FuelID = new SelectList(db.Fuel, "FuelID", "Name", derivation.FuelID);
            ViewBag.MotorID = new SelectList(db.Motor, "MotorID", "Name", derivation.MotorID);
            return View(derivation);
        }

        // POST: Derivations/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DerivationID,Description,MotorID,FuelID,Mnemonic_Bodystyle")] Derivation derivation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(derivation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Mnemonic_Bodystyle = new SelectList(db.CarBuild, "Mnemonic_Bodystyle", "Mnemonic_Vehicle", derivation.Mnemonic_Bodystyle);
            ViewBag.FuelID = new SelectList(db.Fuel, "FuelID", "Name", derivation.FuelID);
            ViewBag.MotorID = new SelectList(db.Motor, "MotorID", "Name", derivation.MotorID);
            return View(derivation);
        }

        // GET: Derivations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Derivation derivation = db.Derivation.Find(id);
            if (derivation == null)
            {
                return HttpNotFound();
            }
            return View(derivation);
        }

        // POST: Derivations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Derivation derivation = db.Derivation.Find(id);
            db.Derivation.Remove(derivation);
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
