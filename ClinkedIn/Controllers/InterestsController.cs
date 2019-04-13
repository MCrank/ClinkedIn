﻿using Microsoft.AspNetCore.Mvc;
using ClinkedIn.Data;
using ClinkedIn.Models;
using ClinkedIn.Validators;

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
      //  [HttpGet("{id}", Name = "GetInterestsById")]
      //  [ProducesResponseType(200)]
      //  [ProducesResponseType(204)]
      //  [ProducesResponseType(400)]
      //  public ActionResult<Interest> GetInterestsByUserId(int id)
      //  {
      //      return Ok(_interestsRepository.GetInterestsByUserId(id));
      //  }

        // GET: api/Interest/Litter Removal
        [HttpGet("{interest}", Name = "GetUsersByInterest")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public ActionResult<Interest> GetUsersByInterest(string interest)
        {
           // var allUsers = _usersRepository.
            return Ok(_interestsRepository.GetUsersByInterest(interest));
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

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
