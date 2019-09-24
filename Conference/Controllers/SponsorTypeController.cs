using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Areas.Admin.Models;
using Conference.Domain.Entities;
using Conference.Models;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Areas.Controllers
{
    [Area("Admin")]
    public class SponsorTypeController : Controller
    {

        private ISponsorTypesService sponsorType;
        public SponsorTypeController(ISponsorTypesService sponsorType)
        {
            this.sponsorType = sponsorType;
        }
        // GET: SponsorType
        public ActionResult Index()
        {
            var getSponsorTypes = sponsorType.GetSponsorTypes();
            return View(getSponsorTypes);
        }

        // GET: SponsorType/Details/5
        public ActionResult Details(int id)
        {
            var getSponsorTypeById = sponsorType.GetById(id);
            SponsorTypeViewModel model = new SponsorTypeViewModel();
            model.InjectFrom(getSponsorTypeById);
            return View(model);
        }

        // GET: SponsorType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SponsorType/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SponsorTypeViewModel model)
        {
            if (ModelState.IsValid)
            {

                SponsorTypes newSponsorType = new SponsorTypes();
                newSponsorType.InjectFrom(model);

                var createSponsorType = sponsorType.CreateSponsorType(newSponsorType);
                if (createSponsorType == null)
                {
                    ModelState.AddModelError("CompanyName", "Must be unique");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: SponsorTypes/Edit/5
        public ActionResult Edit(int id)
        {
            var edit = sponsorType.GetById(id);
            SponsorTypeViewModel model = new SponsorTypeViewModel();
            model.InjectFrom(edit);

            return View(model);
        }


        // POST: SponsorTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SponsorTypeViewModel model)
        {
            SponsorTypes edit = new SponsorTypes();
            edit.InjectFrom(model);
            var createNewSponsorType = sponsorType.Update(edit);
            return RedirectToAction(nameof(Index));
        }

        // GET: SponsorTypes/Delete/5
        public ActionResult Delete(int id)
        {
            var delete = sponsorType.GetById(id);

            SponsorTypeViewModel model = new SponsorTypeViewModel();

            model.InjectFrom(delete);

            return View(model);
        }

        // POST: SponsorTypes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SponsorTypeViewModel model)
        {

            SponsorTypes deleteSponsorType = new SponsorTypes();

            deleteSponsorType = sponsorType.GetById(id);

            model.InjectFrom(deleteSponsorType);

            sponsorType.DeleteSponsorType(deleteSponsorType);

            return RedirectToAction(nameof(Index));

        }
    }
}