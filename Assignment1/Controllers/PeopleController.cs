using Assignment1.Models;
using Assignment1.Validators;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : Controller
    {
        public PeopleController() { 
            //constructer
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            PersonValidator validator = new PersonValidator();
            var result = validator.Validate(person);
            if (!result.IsValid)
                return BadRequest();
            return Ok(person);
        }
    }
}
