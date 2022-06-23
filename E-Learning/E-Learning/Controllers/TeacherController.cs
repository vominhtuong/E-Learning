using E_Learning.Models;
using E_Learning.Service;
using E_Learning.ViewModels;
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
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_teacher.GetAll());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        //Get/id
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            try
            {
                var data = _teacher.GetByID(id);
                if(data !=null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError); 
            }
        }

        //Post
        [HttpPost]
        public IActionResult Post(TeacherVM teacher)
        {
            try
            {
                return Ok(_teacher.Post(teacher));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        //Put
        [HttpPut("id")]
        public IActionResult Put (int id, TeacherVM teacher)
        {
            if(id != teacher.Id)
            {
                return BadRequest();
            }
            try
            {
                _teacher.Put(teacher);
                return NoContent();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        //Delelte
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _teacher.Delete(id);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
