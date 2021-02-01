using System;
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
            return View(sinisters.ToListAsync());
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
            var vm = new SinisterViewModel();

            //ViewBag.ActivitySectorId = new SelectList(db.ActivitySectors, "ActivitySectorId", "Name");
            //ViewBag.Clientid = new SelectList(db.Clients, "ClientId", "Code");
            //ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Code");
            //ViewBag.CurrencyId = new SelectList(db.Currencies, "CurrencyId", "Name");
            //ViewBag.DestructionLevelId = new SelectList(db.DestructionLevels, "DestructionLevelId", "Name");
            //ViewBag.DocumentId = new SelectList(db.Documents, "DocumentId", "Name");
            //ViewBag.SinisterStatusId = new SelectList(db.SinisterStatus, "SinisterStatusId", "Name");
            //ViewBag.SinisterTypeId = new SelectList(db.SinisterTypes, "SinisterTypeId", "Name");
            //ViewBag.SiteId = new SelectList(db.Sites, "SiteId", "Code");
            //ViewBag.UserId = new SelectList(db.Users, "Userid", "EmployeeID");

            ViewBag.newListKeyword = new List<Keywords>();
            ViewBag.sinisterid=1;

            vm.ListClient = GetAllClient();
            vm.ListSite = GetAllSite();
            vm.ListCountries = GetAllCountries();
            vm.ListActivitySector = GetAllActivitySectors();
            vm.ListCurrency = GetAllCurrencies();
            vm.ListLob = GetAllLobs();
            vm.ListSinisterType = GetAllSinisterType();
            vm.ListDestructionLevel = GetAllDestructionLevels();
            //vm.ListKeyword = GetKeywordList(ViewBag.sinisterid);
            //vm.ListSinisterKeyword = GetAllSinisterKeywords();
            

            ViewBag.SiteId = new SelectList(db.Sites,"SiteId","Name");


            return View(vm);
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

        //List<Currencies> ListCurrency { get; set; }

        public List<Clients> GetAllClient()
        {
            var lclient = (from c in db.Clients
                           select c).ToList();

            return lclient;
        }

        public List<Sites> GetAllSite()
        {
            var lsite = (from s in db.Sites
                           select s).ToList();

            return lsite;
        }
        public List<SinisterTypes> GetAllSinisterType()
        {
            var lsinisterType = (from st in db.SinisterTypes
                                    select st).ToList();

            return lsinisterType;
        }
        public List<Countries> GetAllCountries()
        {
            var lcountries = (from c in db.Countries
                           select c).ToList();

            return lcountries;
        }
        public List<Lobs> GetAllLobs()
        {
            var llobs = (from l in db.Lobs
                           select l).ToList();

            return llobs;
        }
        public List<ActivitySectors> GetAllActivitySectors()
        {
            var lactivitySectors = (from ase in db.ActivitySectors
                                    select ase).ToList();

            return lactivitySectors;
        }
        public List<DestructionLevels> GetAllDestructionLevels()
        {
            var ldestrcutionLeveles = (from dl in db.DestructionLevels
                                        select dl).ToList();

            return ldestrcutionLeveles;
        }
        public List<Currencies> GetAllCurrencies()
        {
            var lcurrencies = (from cr in db.Currencies
                                select cr).ToList();

            return lcurrencies;
        }

        public List<Keywords> GetAllKeywords()
        {
            var lkeyword = (from k in db.Keywords
                               select k).ToList();

            return lkeyword;
        }

        public List<SinisterKeywords> GetAllSinisterKeywords()
        {
            var lsinisterKeyword = (from sk in db.SinisterKeywords
                                    select sk).ToList();

            return lsinisterKeyword;
        }


        /////////////////////////////////////////////////////Action result for ajax call///////////////////////////////////////////////////////////:
        [HttpPost]
        public ActionResult GetSiteByClientId(int clientId)
        {
            List<Sites> objSite = new List<Sites>();
            objSite = GetAllSite().Where(s => s.Clientid == clientId).ToList();
            SelectList obgSite = new SelectList(objSite,"SiteId","Name",0);

            return Json(obgSite);
        }

        [HttpPost]
        public ActionResult GetSinisterTypeByLobID (int lobid)
        {
            List<SinisterTypes> objSinisterType = new List<SinisterTypes>();
            objSinisterType = GetAllSinisterType().Where(st => st.LobId == lobid).ToList();
            SelectList obgSinisterType = new SelectList(objSinisterType, "SinisterTypeId", "Name", 0);

            return Json(obgSinisterType);
        }



        //[HttpPost]
        //public ActionResult GetCountriesByClientId(int clienid)
        //{
        //    var siteList = (from s in db.Sites
        //                 where s.Clientid == clienid
        //                 select s).ToList();

        //    List<Countries> countryList = new List<Countries>();
        //    countryList.Clear();

        //    Countries country = new Countries();

        //    foreach( var item in siteList){
        //        country = (from c in db.Countries
        //                   where c.CountryId == item.CountryId
        //                   select c).SingleOrDefault();

        //        countryList.Add(country);
        //    }


        //    List<Countries> objCountry = new List<Countries>();
        //    objCountry = countryList;
        //    SelectList obgCountry = new SelectList(objCountry, "CountryId", "Name", 0);

        //    return Json(obgCountry);
        //}


        [HttpPost]
        public ActionResult GetCountriesBySiteId(int siteid)
        {
            var site = (from s in db.Sites
                        where s.SiteId == siteid
                        select s).FirstOrDefault();

            List<Countries> objCountry = new List<Countries>();
            objCountry = db.Countries.Where(st => st.CountryId == site.CountryId).ToList();
            SelectList obgCountry = new SelectList(objCountry, "CountryId", "Name", 0);

            return Json(obgCountry);
        }


        [HttpPost]
        public ActionResult GetKeywordBySinisterTypeId(int sinisterTypeid)
        {
            List<Keywords> objKeyword = new List<Keywords>();
            objKeyword = db.Keywords.Where(k => k.SinisterTypeId == sinisterTypeid).ToList();
            SelectList obgKeyword = new SelectList(objKeyword, "KeywordId", "Name", 0);

            return Json(obgKeyword);
        }


        [HttpPost]
        public ActionResult GetKeywordList(int sinisterTypeid)
        {
            List<Keywords> lstKeyword = new List<Keywords>();
            lstKeyword = db.Keywords.Where(st => st.SinisterTypeId == sinisterTypeid).ToList();
            SelectList obgKey = new SelectList(lstKeyword, "KeywordId", "Name", 0);
            return Json(obgKey);
        }

    }
}
