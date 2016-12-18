using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IceYaa_ASP.NET.Models;

namespace IceYaa_ASP.NET.Controllers
{
    public class TableBooksController : Controller
    {
        private TableBookDBContext db = new TableBookDBContext();

        // GET: TableBooks
        public ActionResult Index()
        {
            return View(db.TableBooks.ToList());
        }

        // GET: TableBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableBook tableBook = db.TableBooks.Find(id);
            if (tableBook == null)
            {
                return HttpNotFound();
            }
            return View(tableBook);
        }

        // GET: TableBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TableBooks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Floor,TableNo,Status,Firstname,Lastname,Telephone,DateBooking")] TableBook tableBook)
        {
            if (ModelState.IsValid)
            {
                db.TableBooks.Add(tableBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tableBook);
        }

        // GET: TableBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableBook tableBook = db.TableBooks.Find(id);
            if (tableBook == null)
            {
                return HttpNotFound();
            }
            return View(tableBook);
        }

        // POST: TableBooks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Floor,TableNo,Status,Firstname,Lastname,Telephone,DateBooking")] TableBook tableBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tableBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tableBook);
        }

        // GET: TableBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableBook tableBook = db.TableBooks.Find(id);
            if (tableBook == null)
            {
                return HttpNotFound();
            }
            return View(tableBook);
        }

        // POST: TableBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TableBook tableBook = db.TableBooks.Find(id);
            db.TableBooks.Remove(tableBook);
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
