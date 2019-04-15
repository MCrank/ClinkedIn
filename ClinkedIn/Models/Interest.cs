using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Models
{
    public class Interest
    {
        // Constructor method for when we create a new instance - only for seed data //
        public Interest(string name, int userId)
        {
            Name = name;
            UserId = userId;
        }

        // Jungle Overloading because the method name is the same, but the parameters are different  //
        // Not for seed data, this is for when a user wants to add an interest //
        public Interest(int interestid, string name, int userid)
        {
            InterestId = interestid;
            Name = name;
            UserId = userid;
        }

        // Properties of what make up interests //
        public int InterestId { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
    }
}
