using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rocky.Data;
using Rocky.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;

namespace Rocky.Controllers
{
    public class ExamController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExamController(ApplicationDbContext db)
        {
            _db = db;
           
        }

        public IActionResult Index()
        {
            
        

            IEnumerable<Exam> objList = _db.Exam;
            
            foreach (var obj in objList)
            {
                obj.Category = _db.Category.FirstOrDefault(u => u.Id == obj.CategoryId);
            }
            return View(objList);


            /*IEnumerable<Exam> objList1 = _db.Exam*/;

            //foreach (var obj in objList1)
            //{
            //    obj.Options = _db.Options.FirstOrDefault(u => u.Id == obj.OptionsId);
            //}
            //return View(objList1);

        }
        [HttpPost]
        public int Add(int number1)
        {
            return number1;
        }



        //Get - Create
        public IActionResult Create(int? id)
        {
            IEnumerable<SelectListItem> CategoryDropDown = _db.Category.Select(i=> new SelectListItem
            {
                Text=i.Name,
                Value = i.Id.ToString()
            });
            ViewBag.CategoryDropDown = CategoryDropDown;


            //IEnumerable<SelectListItem> OptionsDropDown = _db.Options.Select(i => new SelectListItem
            //{
            //    Text = i.Name,
            //    Value = i.Id.ToString()
            //});
            //ViewBag.OptionsDropDown = OptionsDropDown;

            Exam exam = new Exam();
            if (id == null)
            {
                //this is for create
                return View(exam);
            }
            else
            {
                exam = _db.Exam.Find(id);
                if (exam == null)
                {
                    return NotFound();
                }
                return View(exam);
            }

        }
        //Post - Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert1(List< Exam> obj, string dataToEvaluate) 
        { 
            if (ModelState.IsValid)
            {
                var exam = new Exam(); 
           
                
                ViewBag.Name = "Вы выбрали - " + dataToEvaluate;

            }
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Exam obj)
        {
            if (ModelState.IsValid)
            {
                var exam = new Exam();

                _db.Exam.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(obj);
        }




        //Get - Edit
        public IActionResult Edit(int id)
        {
            IEnumerable<SelectListItem> CategoryDropDown = _db.Category.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            ViewBag.CategoryDropDown = CategoryDropDown;

            

            if (id == 0)
            {
                return NotFound();
            }
            var obj = _db.Exam.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);


        }
        //Post - Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Exam obj)
        {

          
            _db.Exam.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }


        //Get - delete
        public IActionResult Delete(int id)
        {
            IEnumerable<SelectListItem> CategoryDropDown = _db.Category.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            ViewBag.CategoryDropDown = CategoryDropDown;

            if (id == 0)
            {
                return NotFound();
            }
            var obj = _db.Exam.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //Post - delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {

            var obj = _db.Exam.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Exam.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }

    }
}
