using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Models
{
// This will be called within ServicesController.cs to create a new service
    public class CreateService
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
