using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Models
{
    public class Associate
    {
        public Associate(int userId, int associateId, string clinkType)
        {
            UserId = userId;
            AssociateId = associateId;
            ClinkType = clinkType;
        }

        public Associate(int id, int userId, int associateId, string clinkType)
        {
            Id = id;
            UserId = userId;
            AssociateId = associateId;
            ClinkType = clinkType;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int AssociateId { get; set; }
        public string ClinkType { get; set; }
    }
}
