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
    public class SponsorController : Controller
    {

        private ISponsorsService sponsor;
        public SponsorController(ISponsorsService sponsor)
        {
            this.sponsor = sponsor;
        }
        // GET: Sponsor
        public ActionResult Index()
        {
            var getSponsors = sponsor.GetSponsors();
            return View(getSponsors);
        }

        // GET: Sponsor/Details/5
        public ActionResult Details(int id)
        {
            var getSponsorById = sponsor.GetById(id);
            SponsorViewModel model = new SponsorViewModel();
            model.InjectFrom(getSponsorById);
            return View(model);
        }

        // GET: Sponsor/Create
        public ActionResult Create()
        {
            SponsorViewModel model = new SponsorViewModel();
            return View(model);
        }

        // POST: Sponsor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SponsorViewModel model)
        {
            if (ModelState.IsValid)
            {

                Sponsors newSponsor = new Sponsors();
                newSponsor.InjectFrom(model);

                var createSponsor = sponsor.CreateSponsor(newSponsor);
                if (createSponsor == null)
                {
                    ModelState.AddModelError("CompanyName", "Must be unique");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Sponsors/Edit/5
        public ActionResult Edit(int id)
        {
            var edit = sponsor.GetById(id);
            SponsorViewModel model = new SponsorViewModel();
            model.InjectFrom(edit);

            return View(model);
        }


        // POST: Sponsors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SponsorViewModel model)
        {
            Sponsors edit = new Sponsors();
            edit.InjectFrom(model);
            var createNewSponsor = sponsor.Update(edit);
            return RedirectToAction(nameof(Index));
        }

        // GET: Sponsors/Delete/5
        public ActionResult Delete(int id)
        {
            var delete = sponsor.GetById(id);

            SponsorViewModel model = new SponsorViewModel();

            model.InjectFrom(delete);

            return View(model);
        }

        // POST: Sponsors/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SponsorViewModel model)
        {

            Sponsors deleteSponsor = new Sponsors();

            deleteSponsor = sponsor.GetById(id);

            model.InjectFrom(deleteSponsor);

            sponsor.DeleteSponsor(deleteSponsor);

            return RedirectToAction(nameof(Index));

        }
    }
}