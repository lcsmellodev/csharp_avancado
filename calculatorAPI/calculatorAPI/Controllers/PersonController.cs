using calculatorAPI.Model;
using calculatorAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace calculatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
       
        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());

        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person =  _personService.FindById(id);
            if(person == null) { return NotFound(); }
            return Ok(person);
        }


        [HttpPost("{id}")]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) { return BadRequest(); }
            return Ok(_personService.Create(person));
        }

        public IActionResult Put([FromBody] Person person)
        {
            if (person == null) { return BadRequest(); }
            return Ok(_personService.Update(person));
               
        }

        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            return NoContent();
        }





    }
}