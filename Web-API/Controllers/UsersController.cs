using Microsoft.AspNetCore.Mvc;
using Servicies;
using Entities;
using System.Text.Json;
using Web_API;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IClassService serv;

        public UsersController(IClassService classService)
        {
            serv = classService;
        }


        // ClassService serv=new ClassService();

        // GET: api/<Users>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Users>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return Ok(serv.GetUserById(id));
        }

        string filePath = "file.txt";

        // POST api/<Users>
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
           user=serv.AddUser(user);
            return CreatedAtAction(nameof(Get), new { id = user.id },
            user);
        }



        [HttpPost("login")]
        public ActionResult<User> Login([FromBody] LoginUser loginUser)
        {
  
            User user = serv.LoginUser(loginUser);
            if(user != null) 
                return Ok(user);
            return NotFound();
 
        }


        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user2)
        {
          serv.UpdateUserById(id,user2);
        }

        // DELETE api/<Users>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
