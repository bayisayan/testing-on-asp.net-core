using Microsoft.AspNetCore.Mvc;
using Rocky.Data;
using Rocky.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Rocky.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            IEnumerable<Product> objList = _db.Products;
            foreach (var obj in objList)
            {
                obj.Category = _db.Category.FirstOrDefault(u => u.Id == obj.CategoryId);
            }
            return View(objList);
        }
        //Get - Upsert
        public IActionResult Upsert(int? id)
        {
            Product product = new Product();
            if (id == null)
            {
                //this is for create
                return View(product);
            }
            else
            {
                product=_db.Products.Find(id);
                if (product == null)
                {
                    return NotFound();
                }
                return View(product);
            }
            
        }
        //Post - Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Product obj)
        {
            if (ModelState.IsValid) { 
            var product = new Product();

            _db.Products.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
            return View(obj);
        }








        //Get - delete
        public IActionResult Delete(int id)
        {
            if (id == 0) 
            {
                return NotFound();
            }
            var obj = _db.Products.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //Post - delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {

            var obj = _db.Products.Find(id);
            if(obj == null)     
            { return NotFound(); 
            }
            _db.Products.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }

    }

}