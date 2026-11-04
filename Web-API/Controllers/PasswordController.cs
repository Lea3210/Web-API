using Microsoft.AspNetCore.Mvc;
using Servicies;
using Zxcvbn;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordController : ControllerBase
    {
        // ClassService service = new ClassService();

        IClassService serv;

        public PasswordController(IClassService classService)
        {
            serv = classService;
        }
        // GET: api/<PasswordController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PasswordController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PasswordController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok(serv.CheckPassword(value));

        }

        // PUT api/<PasswordController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PasswordController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
