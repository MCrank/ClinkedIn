using ClinkedIn.Models;
using System.Collections.Generic;


namespace ClinkedIn.Data
{
    public class InterestsRepository
    {
        static List<Interest> _interests = new List<Interest>
        {
            new Interest(1, "Weightlifting", 1),
            new Interest(2, "Escape Planning", 2),
            new Interest(3, "Amateur Tattooing", 3),
            new Interest(4, "Litter Removal", 4),
            new Interest(5, "Cell Block Decor", 4),
            new Interest(5, "Cell Block Decor", 1),
            new Interest(6, "Library Time", 6),
            new Interest(7, "Shiv Collecting", 7),
            new Interest(8, "Comparing Scars", 8),
            new Interest(8, "Comparing Scars", 9),
            new Interest(8, "Comparing Scars", 3),
            new Interest(9, "Wall Staring", 9),
            new Interest(10, "Prison Ball", 10),
            new Interest(11, "Regret Reflecting", 11),
            new Interest(11, "Regret Reflecting", 4),
            new Interest(12, "Custodial Arts", 12),
            new Interest(13, "Cafeteria Culiary", 13),
            new Interest(13, "Cafeteria Culiary", 13),
            new Interest(14, "Experiencing Sunshine", 14),
            new Interest(15, "Fighting Wardens", 15),

        };

        public List<Interest> GetAllInterests()
        {
            return _interests;
        }

        //public List<Interest> GetInterestsByUserId(int id)
        //{
        //    return _interests
        //}

        public Interest AddInterest(string name, int userId)
        {
            var newInterest = new Interest(name, userId)
            {
                InterestId = _interests.Count + 1,
            };
            _interests.Add(newInterest);

            return newInterest;
        }
    }
}