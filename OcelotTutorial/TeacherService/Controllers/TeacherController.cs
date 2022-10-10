using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeacherService.Services;

namespace TeacherService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository _repository;
        public TeacherController(ITeacherRepository repository) =>
            _repository = repository;

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());

        }

        [HttpGet("{Id}")]
        public IActionResult Get(int id)
        {
            var teacher = _repository.Get(id);
            if(teacher is null)
                return NotFound();

            return Ok(teacher);
        }
    }
}
