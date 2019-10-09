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

namespace Conference.Controllers
{
    public class TalkController : Controller
    {

        private ITalksService talk;
        public TalkController(ITalksService talk)
        {
            this.talk = talk;
        }
        // GET: Talk
        public ActionResult Index()
        {
            var getTalks = talk.GetTalks();
            return View(getTalks);
        }

        // GET: Talk/Details/5
        public ActionResult Details(int id)
        {
            var getTalkById = talk.GetById(id);
            TalksViewModel model = new TalksViewModel();
            model.InjectFrom(getTalkById);
            return View(model);
        }

        // GET: Talk/Create
        public ActionResult Create()
        {
            return View();
        }
        /*
        // POST: Talk/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TalksViewModel model)
        {
            {
                if (ModelState.IsValid)
                {

                    Talks talksToAdd = new Talks();
                    talksToAdd.InjectFrom(model);

                    var addedTalks = talk.CreateTalk(talksToAdd);
                    if (addedTalks == null)
                    {
                        ModelState.AddModelError("CompanyName", "Must be unique");
                        return View(model);
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
        }

        // GET: Talks/Edit/5
        public ActionResult Edit(int id)
        {
            var edit = talk.GetById(id);
            TalksViewModel model = new TalksViewModel();
            model.InjectFrom(edit);

            return View(model);
        }


        // POST: Talks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TalksViewModel model)
        {
            Talks edit = new Talks();
            edit.InjectFrom(model);
            var createNewTalk = talk.Update(edit);
            return RedirectToAction(nameof(Index));
        }

        // GET: Talks/Delete/5
        public ActionResult Delete(int id)
        {
            var delete = talk.GetById(id);

            TalksViewModel model = new TalksViewModel();

            model.InjectFrom(delete);

            return View(model);
        }

        // POST: Talks/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TalksViewModel model)
        {

            Talks deleteTalk = new Talks();

            deleteTalk = talk.GetById(id);

            model.InjectFrom(deleteTalk);

            talk.DeleteTalk(deleteTalk);

            return RedirectToAction(nameof(Index));

        }
        */
    }
}