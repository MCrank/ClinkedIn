using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn.Models;

namespace ClinkedIn.Data
{
    public class ServicesRepository
    {
        static List<Services> _services = new List<Services>();

        public Services AddServices(int serviceid, string name, string description, int userid)
        {
            var serviceone = new Services(1, "Joe", "life advice", 14);
            var servicetwo = new Services(2, "Bill", "life advice", 14);
            var servicethree = new Services(3, "Larry", "life advice", 14); 
            var servicefour = new Services(3, "Jack", "life advice", 14); 
            var servicefive = new Services(3, "Dale", "life advice", 14); 
        }


        public IEnumerable<Services> GetAllServices()
        {
            return _services;
        }


    }
}
