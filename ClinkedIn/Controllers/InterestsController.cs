using Microsoft.AspNetCore.Mvc;
using ClinkedIn.Data;
using ClinkedIn.Models;
using ClinkedIn.Validators;
using System.Linq;

namespace ClinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestsController : ControllerBase
    {
        // Creating your readonly access to the necessary repositories //
        readonly InterestsRepository _interestsRepository;
        readonly UserRepository _usersRepository;
        readonly CreateInterestRequestValidator _validator;

        public InterestsController()
        {
            // Setting the controller to have access to the necessary repositories //
            _interestsRepository = new InterestsRepository();
            _usersRepository = new UserRepository();
            _validator = new CreateInterestRequestValidator();
        }

        // Pulling all interests as a group //
        // GET: api/Interests
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult GetAllInterests()
        {
            return Ok(_interestsRepository.GetAllInterests());
        }

        // Pulling all of the specific interests by User ID //
        // GET: api/Interests/user/5
        [HttpGet("user/{id}", Name = "GetInterestsById")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public ActionResult<Interest> GetInterestsByUserId(int id)
        {
            return Ok(_interestsRepository.GetInterestsByUserId(id));
        }

        // Pulling the list of Users and Joining them by interest string //
        // GET: api/Interest/Litter Removal
        [HttpGet("{interest}", Name = "GetUsersByInterest")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public ActionResult<Interest> GetUsersByInterest(string interest)
        {
            // Accessing All Users from the user repository //
            var users = _usersRepository.GetAllUsers();
            // matching the user interests to the list by lowercase and returning the data //
            var userIdInterests =(_interestsRepository.GetUsersByInterest(interest.ToLower()));
            // setting the result to join the users who share like interests //
            var result = users.Join(userIdInterests, 
                user => user.Id, 
                interestId => interestId.UserId, 
                (user, interestId) => new { Name = user.NickName });
            // If statement to return sorry message if count is 0 //
            if (result.Count()< 1 ) 
            {
                return NotFound($"Sorry Bruh, We Can't Find That {interest} ");                
            }
            else
            {
                // If ok, then it will return the result varaible which is our users Nicknames //
                return Ok(result);
            }
            
        }

        // Adding your interests to the List of interest //
        // POST: api/Interests
        [HttpPost("register")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public ActionResult AddInterest([FromBody]CreateInterestRequest newInterestRequest)
        {
            if (_validator.InterestValidate(newInterestRequest))
            {
                return BadRequest(new { error = "All Of The Required Fields Not Met" });
            }

            var newInterest = _interestsRepository.AddInterest(newInterestRequest.Name, newInterestRequest.UserId);

            return Created($"api/interests/{newInterest.UserId}", newInterest);
        }

        // PUT: api/Interests/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // Deleting your interest by interst ID //
        // DELETE: api/ApiWithActions/4
        [HttpDelete("delete/{interestId}")]
        public ActionResult DeleteAnInterest(int interestId)
        {
            return Ok(_interestsRepository.DeleteInterest(interestId));
        }
    }
}
