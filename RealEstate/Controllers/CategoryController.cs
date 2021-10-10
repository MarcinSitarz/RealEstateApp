using Microsoft.AspNetCore.Mvc;
using RealEstate.Data;
using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category;

            return View(objList);
        }
        //GET - CREATE
        public IActionResult Create()
        {
          

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //POST - CREATE
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(obj);
        }
    }
}
