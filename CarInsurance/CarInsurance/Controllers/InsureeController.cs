using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        //storing in the database ??
        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,Speedingtickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                //calls the "calculateQuote" function to determine the Quote price
                insuree.Quote = calculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }



        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,Speedingtickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = calculateQuote(insuree);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        //This method does the logic of calculating the quote
        public decimal calculateQuote(Insuree insuree)
        {
            decimal quote = 50m;
            //calculate age
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year; //not accurate, does not consider month
                        
            if (age <= 18)
            {
                quote += 100;
            }
            else if (age > 18 && age <= 25)
            {
                quote += 50;
            }
            else if (age > 25)
            {
                quote += 25;
            }
            if (insuree.CarYear < 2000) { quote += 25; }
            if (insuree.CarYear > 2015) { quote += 25; }
            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera") { quote += 25; }

            quote += insuree.Speedingtickets * 10;
            decimal total = quote;
            if (insuree.DUI) { quote += ((decimal).25 * total); }
            if (insuree.CoverageType) { quote += ((decimal).50 * total); }

            return quote;

        }

        //This method createds ViewModel to restrict the information provided for the Model.
        public ActionResult Admin()
        {
            var insureeVms = new List<InsureeVM>();
            foreach(var insuree in db.Insurees)
            {
                var insureeVm = new InsureeVM();
                insureeVm.Id = insuree.Id;
                insureeVm.FirstName = insuree.FirstName;
                insureeVm.LastName = insuree.LastName;
                insureeVm.EmailAddress = insuree.EmailAddress;
               // decimal quote = calculateQuote(insuree);
                insureeVm.quote = insuree.Quote;
                insureeVms.Add(insureeVm);
            }
            return View(insureeVms);

        }

    }
}
