using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieReview.Models;

namespace MovieReview.Controllers
{
    public class MoviesController : Controller
    {
        private MainDbContext db = new MainDbContext();

        // GET: Movies
        [AllowAnonymous]
        public ActionResult Index()
        {
            var movies = db.Movies.Include(m => m.Directors);
            return View(movies.ToList());
        }

        // GET: Movies/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movies movies = db.Movies.Find(id);
            if (movies == null)
            {
                return HttpNotFound();
            }
            return View(movies);
        }

        // GET: Movies/Create
        [AuthorizeUserAccessLevel(UserRole = "Admin")]
        public ActionResult Create()
        {
            ViewBag.DirectorsID = new SelectList(db.Directors, "DirectorsID", "DirectorName");
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthorizeUserAccessLevel(UserRole = "Admin")]
        public ActionResult Create([Bind(Include = "MoviesID,MovieName,MovieIcon,MovieBio,Rating,ReleaseDate,DirectorsID,Status,Country,Language")] Movies movies)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movies);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DirectorsID = new SelectList(db.Directors, "DirectorsID", "DirectorName", movies.DirectorsID);
            return View(movies);
        }

        // GET: Movies/Edit/5
        [AuthorizeUserAccessLevel(UserRole = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movies movies = db.Movies.Find(id);
            if (movies == null)
            {
                return HttpNotFound();
            }
            ViewBag.DirectorsID = new SelectList(db.Directors, "DirectorsID", "DirectorName", movies.DirectorsID);
            return View(movies);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthorizeUserAccessLevel(UserRole = "Admin")]
        public ActionResult Edit([Bind(Include = "MoviesID,MovieName,MovieIcon,MovieBio,Rating,ReleaseDate,DirectorsID,Status,Country,Language")] Movies movies)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movies).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DirectorsID = new SelectList(db.Directors, "DirectorsID", "DirectorName", movies.DirectorsID);
            return View(movies);
        }

        // GET: Movies/Delete/5
        [AuthorizeUserAccessLevel(UserRole = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movies movies = db.Movies.Find(id);
            if (movies == null)
            {
                return HttpNotFound();
            }
            return View(movies);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movies movies = db.Movies.Find(id);
            db.Movies.Remove(movies);
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
