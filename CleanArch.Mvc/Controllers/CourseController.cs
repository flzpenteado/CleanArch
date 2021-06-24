using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _service;


        public CourseController(ICourseService service)
        {
            _service = service;
        }
        // GET
        public IActionResult Index()
        {
            CourseViewModel model = _service.GetCourses();
            return View(model);
        }
    }
}