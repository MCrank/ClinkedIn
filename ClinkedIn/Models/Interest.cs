using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Models
{
    public class Interest
    {
        public Interest(string name, int userId)
        {
            Name = name;
            UserId = userId;
        }

        public Interest(int interestid, string name, int userid)
        {
            InterestId = interestid;
            Name = name;
            UserId = userid;
        }

        public int InterestId { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
    }
}
