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
    public class CustomerController : Controller
    {
        private IRepositoryWrapper _db;
        public CustomerController(IRepositoryWrapper db)
        {
            _db = db;
        }

        [Route("customers")]
        public IActionResult List(int page = 1, int perPage = 5)
        {
            var data = _db.Customer.Get(includeProperties:"Country").OrderBy(x => x.FirstName).ThenBy(x=>x.LastName);
            var customers = data.ToPagedList(page, perPage);
            ViewBag.Page = page;
            ViewBag.PerPage = perPage;
            return View(customers);
        }
        [HttpGet, Route("[controller]/add"), Route("[controller]/edit/{id}")]
        public IActionResult AddEdit(int id = 0)
        {
            ViewBag.Countries = _db.Country.Get().ToList();
            ViewBag.Action = id == 0 ? "Add" : "Edit";

            TempData["Message"] = "";
            var customer = new Customer();
            
            if (id != 0) customer = _db.Customer.Get(includeProperties: "Country").Where(c => c.CustomerId == id).FirstOrDefault();
            return View("addedit", customer);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var customer = _db.Customer.Get(includeProperties: "Country").Where(c => c.CustomerId == id).FirstOrDefault();
            return View("details", customer);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = _db.Customer.GetById(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Save(Customer customer)
        {
            string action = (customer.CustomerId == 0) ? "Add" : "Edit";
            ViewBag.Action = action;
            ViewBag.Countries = _db.Country.Get().ToList();
            if (ModelState.IsValid)
            {
                if (action == "Add") _db.Customer.Insert(customer);
                else _db.Customer.Update(customer);

                _db.Customer.Save();

                TempData["Message"] = string.Format("{0} {1} was {2}", customer.FirstName, customer.LastName, action == "Add" ? "added" : "edited");
                return RedirectToAction("list");
            }
            return View("AddEdit", customer);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var customer = _db.Customer.GetById(id);
            _db.Customer.Delete(customer);
            _db.Customer.Save();
            return RedirectToAction("list", "customer");
        }
    }
}
