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

        // GET: api/Associates/5/friends
        [HttpGet("{id}/friends", Name = "GetFriendsById")]
        public ActionResult GetFriendsById(int id)
        {
            var usersWithNames = from a in _associateRepository.GetFriendsById(id)
                                 join u in _userRepository.GetAllUsers() on a.UserId equals u.Id
                                 select new { u.NickName, a.AssociateId, a.ClinkType };

            var friendsWithNames = from x in usersWithNames
                                      join y in _userRepository.GetAllUsers() on x.AssociateId equals y.Id
                                      select new { UserName = x.NickName, AssociateName = y.NickName, x.ClinkType };

            return Ok(friendsWithNames);
        }

        // GET: api/Associates/5/enemies
        [HttpGet("{id}/enemies", Name = "GetEnemiesById")]
        public ActionResult GetEnemiesById(int id)
        {
            var usersWithNames = from a in _associateRepository.GetEnemiesById(id)
                                 join u in _userRepository.GetAllUsers() on a.UserId equals u.Id
                                 select new { u.NickName, a.AssociateId, a.ClinkType };

            var enemiessWithNames = from x in usersWithNames
                                   join y in _userRepository.GetAllUsers() on x.AssociateId equals y.Id
                                   select new { UserName = x.NickName, AssociateName = y.NickName, x.ClinkType };

            return Ok(enemiessWithNames);
        }


        // GET: api/Associates/5
        [HttpGet("{id}", Name = "GetAssociatesById")]
        public ActionResult GetAssociatesById(int id)
        {
            var usersWithNames = from a in _associateRepository.GetAssociatesById(id)
                                 join u in _userRepository.GetAllUsers() on a.UserId equals u.Id
                                 select new { u.NickName, a.AssociateId, a.ClinkType };

            var associatesWithNames = from x in usersWithNames
                                      join y in _userRepository.GetAllUsers() on x.AssociateId equals y.Id
                                      select new { UserName = x.NickName, AssociateName = y.NickName, x.ClinkType };

            return Ok(associatesWithNames);
        }

        // POST: api/Associates
        [HttpPost]
        public ActionResult AddAssociate([FromBody]CreateAssociatesRequest request)
        {
            var newAssociate = _associateRepository.AddAssociate(request.UserId, request.AssociateId, request.ClinkType);
            return Created($"api/associates/{newAssociate.Id}", newAssociate);
        }
    }
}
