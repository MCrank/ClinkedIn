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
        readonly InterestsRepository _interestsRepository;
        readonly UserRepository _usersRepository;
        readonly CreateInterestRequestValidator _validator;

        public InterestsController()
        {
            _interestsRepository = new InterestsRepository();
            _usersRepository = new UserRepository();
            _validator = new CreateInterestRequestValidator();
        }

        // GET: api/Interests
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult GetAllInterests()
        {
            return Ok(_interestsRepository.GetAllInterests());
        }

        // GET: api/Interests/5
        [HttpGet("yomama/{id}", Name = "GetInterestsById")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public ActionResult<Interest> GetInterestsByUserId(int id)
        {
            return Ok(_interestsRepository.GetInterestsByUserId(id));
        }

        // GET: api/Interest/Litter Removal
        [HttpGet("{interest}", Name = "GetUsersByInterest")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public ActionResult<Interest> GetUsersByInterest(string interest)
        {
            var users = _usersRepository.GetAllUsers();
            var userIdInterests =(_interestsRepository.GetUsersByInterest(interest));
            var result = users.Join(userIdInterests, 
                user => user.Id, 
                interestId => interestId.UserId, 
                (user, interestId) => new { Name = user.NickName });
            if (result.Count()< 1 ) 
            {
                return NotFound($"Sorry Bruh, We Can't Find That {interest} ");                
            }
            else
            {
                return Ok(result);
            }
            
        }

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

        // DELETE: api/ApiWithActions/4
        [HttpDelete("delete/{interestId}")]
        public ActionResult DeleteAnInterest(int interestId)
        {
            return Ok(_interestsRepository.DeleteInterest(interestId));
        }
    }
}
