using ClinkedIn.Data;
using ClinkedIn.Models;
using ClinkedIn.Validators;
using Microsoft.AspNetCore.Mvc;

namespace ClinkedIn.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly UserRepository _userRepository;
        readonly CreateUserRequestValidator _validator;

        public UsersController()
        {
            _userRepository = new UserRepository();
            _validator = new CreateUserRequestValidator();
        }

        // GET: api/Users
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult GetAllUsers()
        {
            return Ok(_userRepository.GetUsers());
            //return new string[] { "Tom", "Jerry" };
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        [HttpPost("register")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public ActionResult AddUser([FromBody]CreateUserRequest newUserRequest)
        {
            if(_validator.UserValidate(newUserRequest))
            {
                return BadRequest(new { error = "All the required fields not met" });
            }

            var newUser = _userRepository.AddUser(
                        newUserRequest.Name,
                        newUserRequest.Password,
                        newUserRequest.Gender,
                        newUserRequest.NickName,
                        newUserRequest.Type);

            return Created($"api/users/{newUser.Id}", newUser);
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
