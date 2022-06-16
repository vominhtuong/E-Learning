using E_Learning.Models;
using E_Learning.Service;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TeacherController : Controller
    {
        private readonly ITeacher _teacher;
        public TeacherController(ITeacher teacher)
        {
            _teacher = teacher;
        }
        //Get
        [HttpGet]
        public List<Teacher> GetAll()
        {
            var teacher = _teacher.GetAll().ToList();
            return teacher;
        }
    }
}
