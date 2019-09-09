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
    public class WorkshopController : Controller
    {

        private IWorkshopsService workshop;
        public WorkshopController(IWorkshopsService workshop)
        {
            this.workshop = workshop;
        }
        // GET: Workshop
        public ActionResult Index()
        {
            var getWorkshops = workshop.GetWorkshops();
            return View(getWorkshops);
        }

        // GET: Workshop/Details/5
        public ActionResult Details(int id)
        {
            var getWorkshopById = workshop.GetById(id);
            WorkshopViewModel model = new WorkshopViewModel();
            model.InjectFrom(getWorkshopById);
            return View(model);
        }

        // GET: Workshop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Workshop/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkshopViewModel model)
        {
            if (ModelState.IsValid)
            {

                Workshops newWorkshop = new Workshops();
                newWorkshop.InjectFrom(model);

                var createWorkshop = workshop.CreateWorkshops(newWorkshop);
                if (createWorkshop == null)
                {
                    ModelState.AddModelError("CompanyName", "Must be unique");
                    return View(model);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Workshops/Edit/5
        public ActionResult Edit(int id)
        {
            var edit = workshop.GetById(id);
            WorkshopViewModel model = new WorkshopViewModel();
            model.InjectFrom(edit);

            return View(model);
        }


        // POST: Workshops/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, WorkshopViewModel model)
        {
            Workshops edit = new Workshops();
            edit.InjectFrom(model);
            var createNewWorkshop = workshop.Update(edit);
            return RedirectToAction(nameof(Index));
        }

        // GET: Workshops/Delete/5
        public ActionResult Delete(int id)
        {
            var delete = workshop.GetById(id);

            WorkshopViewModel model = new WorkshopViewModel();

            model.InjectFrom(delete);

            return View(model);
        }

        // POST: Workshops/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, WorkshopViewModel model)
        {

            Workshops deleteWorkshop = new Workshops();

            deleteWorkshop = workshop.GetById(id);

            model.InjectFrom(deleteWorkshop);

            workshop.DeleteWorkshop(deleteWorkshop);

            return RedirectToAction(nameof(Index));

        }
    }
}