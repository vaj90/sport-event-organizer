using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021_CtrlStacks.DbRepository;
using GBCSporting2021_CtrlStacks.Extension;
using GBCSporting2021_CtrlStacks.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;

namespace GBCSporting2021_CtrlStacks.Controllers
{
    public class RegistrationController : Controller
    {
        private IRepositoryWrapper _db;
        private ISession _session;
        public RegistrationController(IHttpContextAccessor accessor, IRepositoryWrapper db)
        {
            _db = db;
            _session = accessor.HttpContext.Session;
        }
        [HttpGet, Route("registrations")]
        public IActionResult Index(int id, int page = 1, int perPage = 5)
        {
            var customer = _db.Customer.Get().Where(x => x.CustomerId == id).FirstOrDefault();
            if (customer == null) return RedirectToAction("getcustomer");
            _session.SetObject("CustomerId", customer.CustomerId);

            var data = _db.Registration.Get(includeProperties: "Customer,Product")
                        .Where(x => x.CustomerId == id);
            var products = data.Select(x => x.ProductId).ToArray();
            var registrations = data.ToPagedList(page, perPage);
            var productlist = _db.Product.Get().Where(x => !products.Any(y => y == x.ProductId)).ToList();

            ViewBag.Customer = customer;
            ViewBag.Products = productlist;
            ViewBag.Page = page;
            ViewBag.PerPage = perPage;
            return View(registrations);
        }
        [HttpGet]
        public IActionResult GetCustomer()
        {
            var customers = _db.Customer.Get().ToList();
            return View(customers);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var registration = _db.Registration.Get(includeProperties: "Customer,Product")
                        .Where(x => x.RegistrationId == id).FirstOrDefault();
            return View(registration);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var registration = await _db.Registration.GetByIdAsync(id);
            _db.Registration.Delete(registration);
            _db.Registration.Save();
            return RedirectToAction("index",new { id= registration.CustomerId});
        }
        [HttpPost]
        public IActionResult Save(int id)
        {
            var customerid = _session.GetObject<int>("CustomerId");
            var customer = _db.Customer.Get().Where(x => x.CustomerId == customerid).FirstOrDefault();

            var data = _db.Registration.Get(includeProperties: "Customer,Product")
                        .Where(x => x.CustomerId == customerid);

            var products = data.Select(x => x.ProductId).ToArray();
            var registrations = data.ToPagedList(1, 5);
            var productlist = _db.Product.Get().Where(x => !products.Any(y => y == x.ProductId)).ToList();

            ViewBag.Customer = customer;
            ViewBag.Products = productlist;
            ViewBag.Page = 1;
            ViewBag.PerPage = 5;

            if (ModelState.IsValid)
            {
                var registration = new Registration
                {
                    CustomerId = customerid,
                    ProductId = id
                };
                _db.Registration.Insert(registration); ;

                _db.Registration.Save();
                var product = _db.Product.Get().Where(x => x.ProductId == id).FirstOrDefault();
                TempData["Message"] = string.Format("{0} was added", product.Name);
                return RedirectToAction("index", new { id = customerid });
            }
            return View("index", registrations);
        }
    }
}
