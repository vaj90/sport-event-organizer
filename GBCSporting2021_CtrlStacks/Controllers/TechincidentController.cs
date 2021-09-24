using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021_CtrlStacks.DbRepository;
using GBCSporting2021_CtrlStacks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;

namespace GBCSporting2021_CtrlStacks.Controllers
{
    public class TechincidentController : Controller
    {
        private IRepositoryWrapper _db;
        public TechincidentController(IRepositoryWrapper db)
        {
            _db = db;
        }
        public IActionResult Get()
        {
            var technicians = _db.Technician.Get().ToList();
            return View(technicians);
        }
        [HttpGet, Route("[controller]/list/{id}")]
        public IActionResult List(int id, int page = 1, int perPage = 5)
        {
            var technician = _db.Technician.Get().Where(x => x.TechnicianId == id).FirstOrDefault();
            ViewBag.Technician = technician != null ? technician.Name : "";
            var data = _db.Incident.Get(includeProperties: "Customer,Product,Technician")
                        .Where(x => x.TechnicianId == id && x.DateClosed==null);
            var incidents = data.ToPagedList(page, perPage);
            ViewBag.Page = page;
            ViewBag.PerPage = perPage;
            return View(incidents);
        }
        [HttpGet, Route("[controller]/edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";

            TempData["Message"] = "";
            var incident = _db.Incident.Get(includeProperties: "Customer,Product,Technician")
                        .Where(c => c.IncidentId == id).FirstOrDefault();
            return View("edit", incident);
        }
        [HttpPost]
        public IActionResult Save(int id, string description, DateTime dateClosed)
        {
            ViewBag.Action = "Edit";
            var incident = _db.Incident.Get(includeProperties: "Customer,Product,Technician")
            .Where(c => c.IncidentId == id).FirstOrDefault();
            if (ModelState.IsValid)
            {
                incident.Description = description;
                incident.DateClosed = dateClosed;
                _db.Incident.Update(incident);

                _db.Incident.Save();

                TempData["Message"] = "Techincident successfully modified";
                return RedirectToAction("list", new { id = incident.TechnicianId});
            }
            return View("edit", incident);
        }
    }
}
