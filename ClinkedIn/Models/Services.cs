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
        public double Price { get; set; }
        public int UserId { get; set; }

        // Constructor Method for when we create a new instance - only for seed data
        public Services(int serviceid, string name, string description, double price, int userid)
        {
            ServiceId = serviceid;
            Name = name;
            Description = description;
            Price = price;
            UserId = userid;
        }

        // Jungle Overloading because the method name is the same, but the parameters are different  
        // Not for seed data, this is for when are hypothectical user adds a service
        public Services(string name, string description, double price)
        {
            // ServiceId = serviceid;
            Name = name;
            Description = description;
            Price = price;
            // UserId = userid;
        }
    }
}
