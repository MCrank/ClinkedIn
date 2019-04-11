using System.Collections.Generic;
using ClinkedIn.Data;
using Microsoft.AspNetCore.Mvc;
using ClinkedIn.Models;

namespace ClinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociatesController : ControllerBase
    {
        readonly AssociateRepository _associateRepository;

        public AssociatesController()
        {
            _associateRepository = new AssociateRepository();
        }

        // GET: api/Associates
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Associates/5
        [HttpGet("{id}", Name = "GetAssociatesById")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Associates
        [HttpPost]
        public ActionResult AddAssociate([FromBody]CreateaAssociatesRequest request)
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
