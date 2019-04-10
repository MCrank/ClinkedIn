using ClinkedIn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Data
{
    public class AssociateRepository
    {
        static List<Associate> _associates = new List<Associate>
        {
            new Associate(1, 1, 4, "Warden"),
            new Associate(2, 2, 4, "Warden"),
            new Associate(3, 3, 4, "Warden"),
            new Associate(4, 5, 4, "Warden"),
            new Associate(5, 6, 4, "Warden"),
            new Associate(6, 7, 4, "Warden"),
            new Associate(7, 8, 4, "Warden"),
            new Associate(8, 9, 4, "Warden"),
            new Associate(9, 10, 4, "Warden"),
            new Associate(10, 11, 4, "Warden"),
            new Associate(11, 12, 4, "Warden"),
            new Associate(12, 13, 4, "Warden"),
            new Associate(13, 14, 4, "Warden"),
            new Associate(14, 15, 4, "Warden"),
            new Associate(15, 1, 15, "Friend"),
            new Associate(16, 1, 8, "Enemy"),
            new Associate(17, 1, 11, "Enemy"),
            new Associate(18, 2, 13, "Enemy"),
            new Associate(19, 2, 3, "Friend"),
            new Associate(20, 2, 5, "Friend"),
            new Associate(21, 3, 10, "Enemy"),
            new Associate(22, 3, 9, "Enemy"),
            new Associate(23, 3, 7, "Enemy"),
            new Associate(24, 5, 14, "Enemy"),
            new Associate(25, 5, 6, "Friend"),
            new Associate(26, 5, 9, "Friend"),
            new Associate(27, 6, 1, "Friend"),
            new Associate(28, 6, 11, "Enemy"),
            new Associate(29, 6, 15, "Enemy"),
            new Associate(30, 7, 14, "Friend")
        };

        public Associate AddAssociate(int userId, int associateId, string clinkType)
        {
            var newAssociate = new Associate(userId, associateId, clinkType);
            newAssociate.Id = _associates.Count + 1;
            _associates.Add(newAssociate);
            return newAssociate;
        }


    }
}
