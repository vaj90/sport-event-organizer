using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021_CtrlStacks.DbRepository;
using GBCSporting2021_CtrlStacks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;

namespace GBCSporting2021_CtrlStacks.Controllers
{
    public class IncidentController : Controller
    {
        private IRepositoryWrapper _db;
        public IncidentController(IRepositoryWrapper db)
        {
            _db = db;
        }

        [Route("incidents")]
        public IActionResult List(int page = 1, int perPage = 5, string filter = "all")
        {
            var data = _db.Incident.Get(includeProperties: "Customer,Product,Technician")
                        .OrderBy(x => x.Customer.FirstName);
            if(filter=="unassigned")
            {
                data = (IOrderedQueryable<Incident>)data.Where(x => x.TechnicianId == null);
            }
            else if(filter == "openincidents")
            {
                data = (IOrderedQueryable<Incident>)data.Where(x => x.DateClosed==null);
            }
            var incidents = data.ToPagedList(page, perPage);
            ViewBag.Page = page;
            ViewBag.PerPage = perPage;
            ViewBag.Filter = filter;
            return View(incidents);
        }
        [HttpGet, Route("[controller]/add"), Route("[controller]/edit/{id}")]
        public IActionResult AddEdit(int id = 0)
        {
            ViewBag.Customers = _db.Customer.Get().ToList();
            ViewBag.Products = _db.Product.Get().ToList();
            ViewBag.Technicians = _db.Technician.Get().ToList();

            ViewBag.Action = id == 0 ? "Add" : "Edit";

            TempData["Message"] = "";
            var incident = new Incident();

            if (id != 0) incident = _db.Incident.Get(includeProperties: "Customer,Product,Technician")
                                    .Where(c => c.IncidentId == id).FirstOrDefault();
            return View("addedit", incident);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var incident = _db.Incident.Get(includeProperties: "Customer,Product,Technician")
                            .Where(c => c.IncidentId == id).FirstOrDefault();
            return View("details", incident);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var incident = _db.Incident.GetById(id);
            return View("delete", incident);
        }
        [HttpPost]
        public IActionResult Save(Incident incident)
        {
            string action = (incident.IncidentId == 0) ? "Add" : "Edit";
            ViewBag.Action = action;

            ViewBag.Customers = _db.Customer.Get().ToList();
            ViewBag.Products = _db.Product.Get().ToList();
            ViewBag.Technicians = _db.Technician.Get().ToList();

            if (ModelState.IsValid)
            {
                if (action == "Add") _db.Incident.Insert(incident);
                else _db.Incident.Update(incident);

                _db.Incident.Save();

                TempData["Message"] = string.Format("incident was {0}", action == "Add" ? "added" : "edited");
                return RedirectToAction("list");
            }
            return View("AddEdit", incident);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var incident = _db.Incident.GetById(id);
            _db.Incident.Delete(incident);
            _db.Incident.Save();
            return RedirectToAction("list", "incident");
        }
    }
}
