using E_Learning.Models;
using E_Learning.Service;
using E_Learning.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : Controller
    {
        private readonly ISubject _subject;
        public SubjectController(ISubject subject)
        {
            _subject = subject;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_subject.GetAll());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var data = _subject.GetById(id);
                if (data != null)
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

        [HttpPut("id")]
        public IActionResult Put (int id, SubjectVM subject)
        {
            if (id != subject.Id)
            {
                return BadRequest();
            }
            try
            {
                _subject.Put(subject);
                return NoContent();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public IActionResult Post(Subject subject)
        {
            try
            {
                return Ok(_subject.Post(subject));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _subject.Delete(id);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
