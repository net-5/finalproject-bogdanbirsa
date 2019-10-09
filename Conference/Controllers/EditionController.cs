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
    public class EditionController : Controller
    {

        private IEditionsService edition;
        public EditionController(IEditionsService edition) 
        {
            this.edition = edition;
        }
        // GET: Edition
        public ActionResult Index()
        {
            var getEditions = edition.GetEditions();
            return View(getEditions);
        }

        // GET: Edition/Details/5
        public ActionResult Details(int id)
        {
            var getEditionById = edition.GetById(id);
            EditionsViewModel model = new EditionsViewModel();
            model.InjectFrom(getEditionById);
            return View(model);
        }
        /*
        // GET: Edition/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Edition/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EditionsViewModel model)
        {
            if (ModelState.IsValid)
            {

                Editions newEdition = new Editions();
                newEdition.InjectFrom(model);

                var createEdition = edition.CreateEdition(newEdition);
                if (createEdition == null)
                {
                    ModelState.AddModelError("CompanyName", "Must be unique");
                    return View(model);
                }
            }
            return RedirectToAction(nameof(Index));          
        }

        // GET: Editions/Edit/5
        public ActionResult Edit(int id)
        {
            var edit = edition.GetById(id);
            EditionsViewModel model = new EditionsViewModel();
            model.InjectFrom(edit);

            return View(model);
        }


        // POST: Editions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EditionsViewModel model)
        {
            Editions edit = new Editions();
            edit.InjectFrom(model);
            var createNewEdition = edition.Update(edit);
            return RedirectToAction(nameof(Index));
        }

        // GET: Editions/Delete/5
        public ActionResult Delete(int id)
        {
            var delete = edition.GetById(id);

            EditionsViewModel model = new EditionsViewModel();

            model.InjectFrom(delete);

            return View(model);
        }

        // POST: Editions/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EditionsViewModel model)
        {

            Editions deleteEdition = new Editions();

            deleteEdition = edition.GetById(id);

            model.InjectFrom(deleteEdition);

            edition.DeleteEdition(deleteEdition);

            return RedirectToAction(nameof(Index));

        }
        */
    }
}