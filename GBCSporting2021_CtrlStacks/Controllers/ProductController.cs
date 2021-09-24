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
    public class ProductController : Controller
    {
        private IRepositoryWrapper _db;
        public ProductController(IRepositoryWrapper db)
        {
            _db = db;
        }

        [Route("products")]
        public IActionResult List(int page = 1, int perPage = 5)
        {
            var data = _db.Product.Get().OrderBy(x => x.Code).ThenBy(x => x.Name);
            var customers = data.ToPagedList(page, perPage);
            ViewBag.Page = page;
            ViewBag.PerPage = perPage;
            return View(customers);
        }
        [HttpGet, Route("[controller]/add"), Route("[controller]/edit/{id}")]
        public IActionResult AddEdit(int id = 0)
        {
            ViewBag.Action = id == 0 ? "Add" : "Edit";

            TempData["Message"] = "";
            var product = new Product();
            
            if (id != 0) product = _db.Product.GetById(id);
            return View("addedit", product);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = _db.Product.GetById(id);
            return View("details", product);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = _db.Product.GetById(id);
            return View("delete", product);
        }
        [HttpPost]
        public IActionResult Save(Product product)
        {
            string action = (product.ProductId == 0) ? "Add" : "Edit";
            ViewBag.Action = action;
            if (ModelState.IsValid)
            {
                if (action == "Add") _db.Product.Insert(product);
                else _db.Product.Update(product);
                
                _db.Product.Save();

                TempData["Message"] = string.Format("{0} was {1}", product.Name, action == "Add" ? "added" : "edited");
                return RedirectToAction("list");
            }
            return View("AddEdit", product);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var product = await _db.Product.GetByIdAsync(id);
            _db.Product.Delete(product);
            _db.Product.Save();
            return RedirectToAction("list", "product");
        }
    }
}
