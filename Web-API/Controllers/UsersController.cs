using Microsoft.AspNetCore.Mvc;
using Servicies;
using Entities;
//This using isn't used in this file: you can remove it
using System.Text.Json;
//This using isn't used in this file: you can remove it
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
           //The assignment asks a weak password (score below 3) to return 400: where should the password check go, before AddUser? The score comes from serv.CheckPassword
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
            //The assignment asks a login with a wrong password to return 204 NoContent: what should this return instead of NotFound?
            return NotFound();
 
        }


        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        //The assignment asks PUT to return Ok(): change void to IActionResult and return Ok() at the end
        public void Put(int id, [FromBody] User user2)
        {
          //The assignment asks a weak password (score below 3) to return 400: where should the password check go, before UpdateUserById?
          serv.UpdateUserById(id,user2);
        }

        // DELETE api/<Users>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
