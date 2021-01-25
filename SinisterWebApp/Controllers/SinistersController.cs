﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SinisterWebApp.Models;

namespace SinisterWebApp.Controllers
{
    public class SinistersController : Controller
    {
        private sinisterEntities db = new sinisterEntities();

        // GET: Sinisters
        public ActionResult Index()
        {
            var sinisters = db.Sinisters.Include(s => s.ActivitySectors).Include(s => s.Clients).Include(s => s.Countries).Include(s => s.Currencies).Include(s => s.DestructionLevels).Include(s => s.Documents).Include(s => s.SinisterStatus).Include(s => s.SinisterTypes).Include(s => s.Sites).Include(s => s.Users);
            return View(sinisters.ToList());
        }

        // GET: Sinisters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sinisters sinisters = db.Sinisters.Find(id);
            if (sinisters == null)
            {
                return HttpNotFound();
            }
            return View(sinisters);
        }

        // GET: Sinisters/Create
        public ActionResult Create()
        {
            ViewBag.ActivitySectorId = new SelectList(db.ActivitySectors, "ActivitySectorId", "Name");
            ViewBag.Clientid = new SelectList(db.Clients, "ClientId", "Code");
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Code");
            ViewBag.CurrencyId = new SelectList(db.Currencies, "CurrencyId", "Name");
            ViewBag.DestructionLevelId = new SelectList(db.DestructionLevels, "DestructionLevelId", "Name");
            ViewBag.DocumentId = new SelectList(db.Documents, "DocumentId", "Name");
            ViewBag.SinisterStatusId = new SelectList(db.SinisterStatus, "SinisterStatusId", "Name");
            ViewBag.SinisterTypeId = new SelectList(db.SinisterTypes, "SinisterTypeId", "Name");
            ViewBag.SiteId = new SelectList(db.Sites, "SiteId", "Code");
            ViewBag.UserId = new SelectList(db.Users, "Userid", "EmployeeID");
            return View();
        }

        // POST: Sinisters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SinisterId,Clientid,SiteId,SinisterTypeId,ActivitySectorId,CountryId,DestructionLevelId,CurrencyId,LoBId,UserId,Consequence,FileOrigine,FileName,AggravatingFactor,Amount,CreateDate,EditDate,KeyWord,CreateUserId,EditUserId,DocumentId,SinisterStatusId")] Sinisters sinisters)
        {
            if (ModelState.IsValid)
            {
                db.Sinisters.Add(sinisters);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActivitySectorId = new SelectList(db.ActivitySectors, "ActivitySectorId", "Name", sinisters.ActivitySectorId);
            ViewBag.Clientid = new SelectList(db.Clients, "ClientId", "Code", sinisters.Clientid);
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Code", sinisters.CountryId);
            ViewBag.CurrencyId = new SelectList(db.Currencies, "CurrencyId", "Name", sinisters.CurrencyId);
            ViewBag.DestructionLevelId = new SelectList(db.DestructionLevels, "DestructionLevelId", "Name", sinisters.DestructionLevelId);
            ViewBag.DocumentId = new SelectList(db.Documents, "DocumentId", "Name", sinisters.DocumentId);
            ViewBag.SinisterStatusId = new SelectList(db.SinisterStatus, "SinisterStatusId", "Name", sinisters.SinisterStatusId);
            ViewBag.SinisterTypeId = new SelectList(db.SinisterTypes, "SinisterTypeId", "Name", sinisters.SinisterTypeId);
            ViewBag.SiteId = new SelectList(db.Sites, "SiteId", "Code", sinisters.SiteId);
            ViewBag.UserId = new SelectList(db.Users, "Userid", "EmployeeID", sinisters.UserId);
            return View(sinisters);
        }

        // GET: Sinisters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sinisters sinisters = db.Sinisters.Find(id);
            if (sinisters == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActivitySectorId = new SelectList(db.ActivitySectors, "ActivitySectorId", "Name", sinisters.ActivitySectorId);
            ViewBag.Clientid = new SelectList(db.Clients, "ClientId", "Code", sinisters.Clientid);
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Code", sinisters.CountryId);
            ViewBag.CurrencyId = new SelectList(db.Currencies, "CurrencyId", "Name", sinisters.CurrencyId);
            ViewBag.DestructionLevelId = new SelectList(db.DestructionLevels, "DestructionLevelId", "Name", sinisters.DestructionLevelId);
            ViewBag.DocumentId = new SelectList(db.Documents, "DocumentId", "Name", sinisters.DocumentId);
            ViewBag.SinisterStatusId = new SelectList(db.SinisterStatus, "SinisterStatusId", "Name", sinisters.SinisterStatusId);
            ViewBag.SinisterTypeId = new SelectList(db.SinisterTypes, "SinisterTypeId", "Name", sinisters.SinisterTypeId);
            ViewBag.SiteId = new SelectList(db.Sites, "SiteId", "Code", sinisters.SiteId);
            ViewBag.UserId = new SelectList(db.Users, "Userid", "EmployeeID", sinisters.UserId);
            return View(sinisters);
        }

        // POST: Sinisters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SinisterId,Clientid,SiteId,SinisterTypeId,ActivitySectorId,CountryId,DestructionLevelId,CurrencyId,LoBId,UserId,Consequence,FileOrigine,FileName,AggravatingFactor,Amount,CreateDate,EditDate,KeyWord,CreateUserId,EditUserId,DocumentId,SinisterStatusId")] Sinisters sinisters)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sinisters).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActivitySectorId = new SelectList(db.ActivitySectors, "ActivitySectorId", "Name", sinisters.ActivitySectorId);
            ViewBag.Clientid = new SelectList(db.Clients, "ClientId", "Code", sinisters.Clientid);
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Code", sinisters.CountryId);
            ViewBag.CurrencyId = new SelectList(db.Currencies, "CurrencyId", "Name", sinisters.CurrencyId);
            ViewBag.DestructionLevelId = new SelectList(db.DestructionLevels, "DestructionLevelId", "Name", sinisters.DestructionLevelId);
            ViewBag.DocumentId = new SelectList(db.Documents, "DocumentId", "Name", sinisters.DocumentId);
            ViewBag.SinisterStatusId = new SelectList(db.SinisterStatus, "SinisterStatusId", "Name", sinisters.SinisterStatusId);
            ViewBag.SinisterTypeId = new SelectList(db.SinisterTypes, "SinisterTypeId", "Name", sinisters.SinisterTypeId);
            ViewBag.SiteId = new SelectList(db.Sites, "SiteId", "Code", sinisters.SiteId);
            ViewBag.UserId = new SelectList(db.Users, "Userid", "EmployeeID", sinisters.UserId);
            return View(sinisters);
        }

        // GET: Sinisters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sinisters sinisters = db.Sinisters.Find(id);
            if (sinisters == null)
            {
                return HttpNotFound();
            }
            return View(sinisters);
        }

        // POST: Sinisters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sinisters sinisters = db.Sinisters.Find(id);
            db.Sinisters.Remove(sinisters);
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
