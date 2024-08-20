using Microsoft.AspNetCore.Mvc;

namespace taskOneMvc.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Getall()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();

        }
       
        public IActionResult Delete()
        {
            return View();
            
        }
    }
}
