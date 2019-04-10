using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Models
{
    public class Interests
    {
        public static List<string> interests = new List<string>()
        { "Weightlifting", "Custodial Arts", "Library Time", "Work Release", "Highway Litter Maintenance",
          "Scrapbooking", "Cell Block Decor", "Crime Comparisons", "Amature Tatooing", "Shiv Collecting", "Toilet Wine Vinification",
          "Wall Staring", "Prison Basketball", "Escape Planning", "Self Reflection", "Cafeteria Culinary Arts",
          "Yo Mama Jokes", };
        private string interest;

        public Interests(string interest)
        {
            this.interest = interest;
        }
    }

    public List<string> interests = new List<string>();
        
        return interests; 


}
