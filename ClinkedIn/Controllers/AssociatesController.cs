using System.Collections.Generic;
using ClinkedIn.Data;
using Microsoft.AspNetCore.Mvc;
using ClinkedIn.Models;
using System.Linq;

namespace ClinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociatesController : ControllerBase
    {
        readonly AssociateRepository _associateRepository;
        readonly UserRepository _userRepository;

        public AssociatesController()
        {
            _associateRepository = new AssociateRepository();
            _userRepository = new UserRepository();
        }

        // GET: api/Associates
        [HttpGet]
        public ActionResult GetAllAssociates()
        {
            var usersWithNames = from a in _associateRepository.GetAssociates()
                                      join u in _userRepository.GetAllUsers() on a.UserId equals u.Id
                                      select new { u.NickName, a.AssociateId, a.ClinkType };

            var associatesWithNames = from x in usersWithNames
                                      join y in _userRepository.GetAllUsers() on x.AssociateId equals y.Id
                                      select new { UserName = x.NickName, AssociateName = y.NickName, x.ClinkType };
            
            
            return Ok(associatesWithNames);
        }

        /*
        // GET: api/Associates
        [HttpGet]
        public ActionResult GetAllAssociates()
        {
            return Ok(_associateRepository.GetAssociates());
        }
        */

        // GET: api/Associates/5
        [HttpGet("{id}", Name = "GetAssociatesById")]
        public ActionResult GetAssociatesById(int id)
        {
            return Ok(_associateRepository.GetAssociatesById(id));
        }

        // POST: api/Associates
        [HttpPost]
        public ActionResult AddAssociate([FromBody]CreateAssociatesRequest request)
        {
            var newAssociate = _associateRepository.AddAssociate(request.UserId, request.AssociateId, request.ClinkType);
            return Created($"api/associates/{newAssociate.Id}", newAssociate);
        }

        // PUT: api/Associates/5
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
