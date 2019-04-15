using ClinkedIn.Models;
using System.Collections.Generic;
using System.Linq;

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
            new Interest(6, "Cell Block Decor", 1),
            new Interest(7, "Library Time", 6),
            new Interest(8, "Shiv Collecting", 7),
            new Interest(9, "Comparing Scars", 8),
            new Interest(10, "Comparing Scars", 9),
            new Interest(11, "Comparing Scars", 3),
            new Interest(12, "Wall Staring", 9),
            new Interest(13, "Prison Ball", 10),
            new Interest(14, "Regret Reflecting", 11),
            new Interest(15, "Regret Reflecting", 4),
            new Interest(16, "Custodial Arts", 12),
            new Interest(17, "Cafeteria Culiary", 13),
            new Interest(18, "Cafeteria Culiary", 13),
            new Interest(19, "Experiencing Sunshine", 14),
            new Interest(20, "Fighting Wardens", 15),

        };

        public List<Interest> GetAllInterests()
        {
            return _interests;
        }
                                                                                                                                

       public Interest GetInterestsByUserId(int interestId)
        {
            var selectedInterests = _interests.Find(Interest => Interest.UserId == interestId);
            return selectedInterests;
        }

        public List<Interest> GetUsersByInterest(string name)
        {
            var selectedUsers = _interests.FindAll(Interest => Interest.Name == name);
            return selectedUsers;
        }

        public List<Interest> DeleteInterest(int Interestid)
        {
            if (_interests.Exists(x => x.InterestId == Interestid))
            {
                var interestToDelete = _interests.Find(x => x.InterestId == Interestid);
                _interests.Remove(interestToDelete);
                return _interests;
            }
            else
            {
                return null;

            }
        }

        public Interest AddInterest(string name, int interestId)
        {
            var newInterest = new Interest(name, interestId)
            {
                InterestId = _interests.Count + 1,
            };
            _interests.Add(newInterest);

            return newInterest;
        }
    }
}