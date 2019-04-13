using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClinkedIn.Data;
using ClinkedIn.Validators;
using ClinkedIn.Models;

namespace ClinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        readonly ServicesRepository _servicesRepository;
        readonly CreateServicesValidator _createServicesValidator;
        // Getting access to Marco's repository
        readonly UserRepository _userRepository;

        public ServicesController()
        {
            _servicesRepository = new ServicesRepository();
            _createServicesValidator = new CreateServicesValidator();
            // Making a copy of Marco's repository 
            _userRepository = new UserRepository();
        }


        // GET: api/Services
        [HttpGet]
        public ActionResult GetServices()
        {
            // return new string[] { "value1", "value2" };
            return Ok(_servicesRepository.GetAllServices());
        }

        // GET: api/Services/5
        [HttpGet("{id}", Name = "GetInmatesServices")]
        public ActionResult GetServicesByID(int id)
        {
            // return "value";
            return Ok(_servicesRepository.GetInmatesServices(id));
        }

        // POST: api/Services
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Services/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("delete/{serviceId}")]
        public ActionResult DeleteAService(int serviceId)
        {
            return Ok(_servicesRepository.DeleteService(serviceId));
        }
        
    }
}
