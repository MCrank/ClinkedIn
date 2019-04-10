using ClinkedIn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Data
{
    public class InterestsRepository
    {
        static List<Interests> _interests = new List<Interests>();

            public Interests AddInterest(string interest)
            {
                var newInterest = new Interests(interest);

                newInterest.Id = _interests.Count + 1;

                _interests.Add(newInterest);

                return newInterest;
            }
        }
    }
