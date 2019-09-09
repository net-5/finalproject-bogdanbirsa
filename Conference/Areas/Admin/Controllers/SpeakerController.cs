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

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpeakerController : Controller
    {

        private ISpeakerService speaker;
        public SpeakerController(ISpeakerService speaker)
        {
            this.speaker = speaker;
        }
        // GET: Edition
        public ActionResult Index()
        {
            var getSpeakers = speaker.GetSpeakers();
            return View(getSpeakers);
        }

        // GET: Speakers/Details/5
        public ActionResult Details(int id)
        {
            var getSpeakerById = speaker.GetById(id);
            SpeakerViewModel model = new SpeakerViewModel();
            model.InjectFrom(getSpeakerById);
            return View(model);
        }

        // GET: Speakers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Speakers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SpeakerViewModel model)
        {
            if (ModelState.IsValid)
            {

                Speakers newSpeaker = new Speakers();
                newSpeaker.InjectFrom(model);

                var createSpeaker = speaker.CreateSpeaker(newSpeaker);
                if (createSpeaker == null)
                {
                    ModelState.AddModelError("CompanyName", "Must be unique");
                    return View(model);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Speakers/Edit/5
        public ActionResult Edit(int id)
        {
            var edit = speaker.GetById(id);
            SpeakerViewModel model = new SpeakerViewModel();
            model.InjectFrom(edit);

            return View(model);
        }


        // POST: Speakers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SpeakerViewModel model)
        {
            Speakers edit = new Speakers();
            edit.InjectFrom(model);
            var createNewSpeaker = speaker.Update(edit);
            return RedirectToAction(nameof(Index));
        }

        // GET: Speakers/Delete/5
        public ActionResult Delete(int id)
        {
            var delete = speaker.GetById(id);

            SpeakerViewModel model = new SpeakerViewModel();

            model.InjectFrom(delete);

            return View(model);
        }

        // POST: Speakers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SpeakerViewModel model)
        {
            Speakers deleteSpeaker = new Speakers();
            deleteSpeaker = speaker.GetById(id);
            model.InjectFrom(deleteSpeaker);
            speaker.DeleteSpeakers(deleteSpeaker);
            return RedirectToAction(nameof(Index));
        }
    }
}