using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021_CtrlStacks.DbRepository;
using GBCSporting2021_CtrlStacks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PagedList.Core;

namespace GBCSporting2021_CtrlStacks.Controllers
{
    public class TechnicianController : Controller
    {
        private IRepositoryWrapper _db;
        public TechnicianController(IRepositoryWrapper db)
        {
            _db = db;
        }

        [Route("technicians")]
        public IActionResult List(int page = 1, int perPage = 5)
        {
            var data = _db.Technician.Get().OrderBy(x => x.Name);
            var technicians = data.ToPagedList(page, perPage);
            ViewBag.Page = page;
            ViewBag.PerPage = perPage;
            return View(technicians);
        }
        [HttpGet, Route("[controller]/add"), Route("[controller]/edit/{id}")]
        public IActionResult AddEdit(int id = 0)
        {
            ViewBag.Action = id == 0 ? "Add" : "Edit";

            TempData["Message"] = "";
            var technician = new Technician();

            if (id != 0) technician = _db.Technician.GetById(id);
            return View("addedit", technician);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var technician = _db.Technician.Get().Where(c => c.TechnicianId == id).FirstOrDefault();
            return View("details", technician);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var technician = _db.Technician.GetById(id);
            return View("delete", technician);
        }
        [HttpPost]
        public IActionResult Save(Technician technician)
        {
            string action = (technician.TechnicianId == 0) ? "Add" : "Edit";
            ViewBag.Action = action;

            if (ModelState.IsValid)
            {
                if (action == "Add") _db.Technician.Insert(technician);
                else _db.Technician.Update(technician); 

                _db.Technician.Save();

                TempData["Message"] = string.Format("{0} was {1}",technician.Name, action == "Add" ? "added" : "edited");
                return RedirectToAction("list");
            }
            return View("AddEdit", technician);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var technician = await _db.Technician.GetByIdAsync(id);
            _db.Technician.Delete(technician);
            _db.Technician.Save();
            return RedirectToAction("list", "technician");
        }
    }
}
