using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Models
{
    public class Services
    {
        // Properties to describe what services are
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

        // Constructor Method for when we create a new instance 
        public Services(int serviceid, string name, string description, int userid)
        {
            ServiceId = serviceid;
            Name = name;
            Description = description;
            UserId = userid;
        }
    }
}
