using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn.Models;
using ClinkedIn.Data;
using Microsoft.AspNetCore.Mvc;

namespace ClinkedIn.Data
{
    public class ServicesRepository
    {
        static List<Services> _services = new List<Services>
        {
        new Services(1, "Counseling", "self explanatory", 10.43, 1),
        new Services(2, "Therapy", "self explanatory", 13.21, 4),
        new Services(3, "Guru", "self explanatory", 10.02, 4),
        new Services(4, "Financial Advising", "self explanatory", 5.03, 2),
        new Services(5, "Meditation", "self explanatory", 4.78, 2),
        new Services(6, "Survival", "self explanatory", 17.53, 5),
        new Services(7, "Yoga", "self explanatory", 30.33, 6),
        new Services(8, "Massage Therapy", "self explanatory", 6.13, 2),
        new Services(9, "Legal Advice", "self explanatory", 20.73, 1),
        new Services(10, "Music Lessons", "self explanatory", 30.31, 4),
        new Services(11, "Yard Psychology", "self explanatory", 30.73, 2),
        new Services(12, "Smuggling", "self explanatory", 22.33, 7),
        new Services(13, "Dietitian", "self explanatory", 30.59, 7),
        new Services(14, "Personal Trainer", "self explanatory", 5.43, 15),
        new Services(15, "Tax Accounting on the outside", "self explanatory", 3.11, 11),
        };

        public List<Services> GetAllServices()
        {
            return _services;
        }

        public List<Services> GetInmatesServices(int id)
        {
            if (_services.Exists(x => x.UserId == id))
            {
                return _services.FindAll(service => service.UserId == id);
            } else
            {
                return null;
            }
            

        }

        public List<Services> DeleteService(int serviceid)
        {
            if (_services.Exists(x => x.ServiceId == serviceid))
            {
                var serviceToDelete = _services.Find(x => x.ServiceId == serviceid);
                _services.Remove(serviceToDelete);
                return _services;  
            }
            else
            {
                return null;

            }
        }

        public Services AddService(string name, string description, double price)
        {
            var newService = new Services(name, description, price)
            {
                ServiceId = _services.Count + 1,

            };
            _services.Add(newService);
            return newService;
            
        }

    }
}
