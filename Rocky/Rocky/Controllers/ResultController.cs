using Microsoft.AspNetCore.Mvc;

namespace Rocky.Models
{
    public class ResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Save()
        {
            return View();
        }
    }
}
