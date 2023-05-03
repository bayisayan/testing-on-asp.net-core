using Microsoft.AspNetCore.Mvc;
using Rocky.Data;
using Rocky.Models;
using System.Collections.Generic;

namespace Rocky.Controllers
{
 
    public class TestsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TestsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Tests> objList = _db.Tests;
            return View(objList);
           
        }
        //Get - Create
        public IActionResult Create()
        {

            return View();
        }
        //Post - Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tests obj)
        {
            _db.Tests.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
