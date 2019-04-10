using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Models
{
    public class CreateaAssociatesRequest
    {
        public int UserId { get; set; }
        public int AssociateId { get; set; }
        public string ClinkType { get; set; }
    }
}
