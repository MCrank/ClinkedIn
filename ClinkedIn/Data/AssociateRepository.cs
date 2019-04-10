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
        }
    }
}
