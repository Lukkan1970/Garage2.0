using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garaget.DataAccessLayer;
using Garaget.Models;

namespace Garaget.Controllers
{
    public class ParkedVehiclesController : Controller
    {
        private GarageContext db = new GarageContext();

        // GET: ParkedVehicles
        public ActionResult Index()
        {
            return View(db.ParkedVehicles.ToList());
        }
        public ActionResult VehicleSearch()
        {
            return View();
        }
        [HttpPost]
        public ActionResult VehicleSearch(string vehicleType, string color, string regNo, string make, string model, int noWheels)
        {
            if (!ModelState.IsValid) return View(HttpStatusCode.InternalServerError);

            var vm = db.ParkedVehicles
                //.Where(v => vehicleType == null || v.VehicleType.ToString().StartsWith(vehicleType))
                //.Where(v => color == null || v.Color.StartsWith(color))
                //.Where(v => make == null || v.Make.StartsWith(make))
                //.Where(v => model == null || v.Model.StartsWith(model))
                //.Where(v => noWheels == 0 || v.NoWheels == noWheels)
                .Where(v => regNo == null || v.RegNo.StartsWith(regNo));

            return View("Index", vm.ToList());
        }

        // GET: ParkedVehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.ParkedVehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/CheckInVehicle
        public ActionResult CheckInVehicle()
        {
            return View();
        }

        // POST: ParkedVehicles/CheckInVehicle
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckInVehicle([Bind(Include = "VehicleType,RegNo,Color,Make,Model,NoWheels")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.ParkedVehicles.Add(parkedVehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/CheckOutVehicle/5
        public ActionResult CheckOutVehicle(int? id)
        {
            ParkedVehicle parkedVehicle = db.ParkedVehicles.Find(id);
            if (parkedVehicle == null)
            {
                return View("VehicleSearch");
            }

            
            db.ParkedVehicles.Remove(parkedVehicle);
            db.SaveChanges();
            return View(parkedVehicle);
        }

        // POST: ParkedVehicles/CheckOutVehicle/5
        [HttpPost, ActionName("CheckOutVehicle")]
        [ValidateAntiForgeryToken]
        public ActionResult CheckOutVehicleConfirmed(int id)//Never called
        {
            
            ParkedVehicle parkedVehicle = db.ParkedVehicles.Find(id);
            db.ParkedVehicles.Remove(parkedVehicle);
            db.SaveChanges();
            return View(parkedVehicle);
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
