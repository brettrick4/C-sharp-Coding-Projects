using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCCarInsurance.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MVCCarInsurance.Controllers
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
        //if (Method1())
        //    if (Method2())
        //    {
        //    }

        // POST: Insuree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                int x = 25;
                int y = 50;
                int z = 100;
                void CalcAge()
                {
                    Insuree insuree = new Insuree();
                    DateTime DateOfBirth = new DateTime();
                    DateTime Dob = Convert.ToDateTime(DateOfBirth);
                    DateTime Now = DateTime.Now;
                    int age = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
                    DateTime PastYearDate = Dob.AddYears(age);
                    int months = 0;
                    for (int i = 1; i <= 12; i++)
                    {
                        if (PastYearDate.AddMonths(i) == Now)
                        {
                            months = i;
                        }
                    }
                
                    int firstPrice = y;
                    if (age < 25)
                    {
                        int newPrice = firstPrice + x;
                        //Console.WriteLine("Age: {0} years current monthly total: {1}", age, newPrice);
                    }
                    else if (age <= 18)
                    {
                        int newPrice = firstPrice + z;
                        //Console.WriteLine("Age: {0} years current monthly total: {1}", age, newPrice);
                    }
                    else if (age >= 100)
                    {
                        int newPrice = firstPrice + x;
                        //Console.WriteLine("Age: {0} years current monthly total: {1}", age, newPrice);
                    }
                    else
                    {
                        int newPrice = firstPrice;
                        //Console.WriteLine("Age: {0} years current monthly total: {1}", age, newPrice);
                    }
                    //Console.ReadLine();
                }

                void YearPrice(int newPrice, int firstPrice)
                {
                    int carYear = new Insuree.CarYear();

                    if (carYear < 2000)
                    {
                        int newAmount = newPrice + x;
                        //Console.WriteLine("Your current estimated total is: {0}", newAmount);
                    }
                    else if (carYear > 2015)
                    {
                        int newAmount = newPrice + x;
                        //Console.WriteLine("Your current estimated total is: {0}", newAmount);
                    }
                    else
                    {
                        int newAmount = newPrice;
                        //Console.WriteLine("Your current estimated total is: {0}", newAmount);
                    }
                    //Console.ReadLine();
                }
                
                void MakePrice(int newAmount)
                {
                    string carMake = Convert.ToString(Insuree.CarMake).ToLower();
                    if (carMake == "Porshe")
                    {
                        int porshePrice = newAmount + x;
                    }
                    else
                    {
                        int porshePrice = newAmount;
                    }
                }
                
                void ModelPrice(int newAmount, string carMake, string carModel)
                {
                    if (carMake == "Porshe" && carModel == "911 Carrera")
                    {
                        int porshePrice = newAmount + y;
                    }
                    else
                    {
                        int porshePrice = newAmount;
                    }
                }

                void TicketCount(int porshePrice)
                {
                    Insuree.SpeedingTickets tickets = new Insuree.SpeedingTickets();
                    if (tickets > 0)
                    {
                        int newTotal = porshePrice * 10;
                    }
                    else
                    {
                        int newTotal = porshePrice;
                    }
                }

                void DUI(int newTotal)
                {
                    Insuree.DUI dui = new Insuree.DUI;
                    if (dui == true)
                    {
                        int nowTotal = (newTotal / 4) + newTotal;
                    }
                    else
                    {
                        int nowTotal = newTotal;
                    }
                }

                void Coverage(int nowTotal)
                {
                    Insuree.CoverageType coverage = new Insuree.CoverageType;
                    if (coverage = "Full")
                    {
                        int finalTotal = (nowTotal / 2) + nowTotal;
                    }
                    else
                    {
                        int finalTotal = nowTotal;
                    }
                }
                Console.ReadLine();


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
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
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
    }
}
