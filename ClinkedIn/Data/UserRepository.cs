using ClinkedIn.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinkedIn.Data
{
    public class UserRepository
    {
        static List<User> _users = new List<User>
        {
            /*
             * 03/13/2017 08:05:34 PM
             * 04/12/2017 10:06:50 PM
             * 05/06/2017 07:40:48 AM
             * 05/07/2017 07:52:50 AM
             * 06/07/2017 01:37:27 PM
             * 06/14/2017 11:16:50 PM
             * 07/27/2017 08:25:57 AM
             * 08/22/2017 09:21:07 PM
             * 10/10/2017 03:27:22 PM
             * 10/21/2017 08:11:49 PM
             * 11/03/2017 07:22:44 AM
             * 11/22/2017 06:19:52 AM
             * 01/05/2018 09:00:11 AM
             * 01/29/2018 07:45:39 PM
             * 02/08/2018 07:36:00 PM
             * 04/04/2018 03:08:49 AM
             * 04/18/2018 07:32:02 PM
             * 05/13/2018 12:52:43 AM
             * 05/20/2018 10:28:31 PM
             * 06/29/2018 05:53:07 AM
             * 07/24/2018 06:24:20 AM
             * 08/11/2018 11:20:31 AM
             * 09/14/2018 10:39:05 PM
             * 10/29/2018 02:40:44 PM
             * 11/18/2018 09:46:30 PM
             * 11/21/2018 11:30:33 AM
             * 12/15/2018 05:52:02 PM
             * 01/07/2019 11:52:26 PM
             * 02/09/2019 02:59:17 AM
             * 04/11/2019 09:38:00 AM
             */
            new User(1, "Jeremiah Ruggirello", "P@ssw0rd!", "Male", "Sweet Cakes", "Inmate", new DateTime()., new DateTime(, true),
            new User(2, "Varo Colombini", "P@ssw0rd!", "Female", "The Dove", "Inmate", true),
            new User(3, "Serenity Herrold", "P@ssw0rd!", "Female", "The Cat", "Inmate", false),
            new User(4, "Marco Crank", "P@ssw0rd!", "Male", "Two Toes", "Warden", true),
            new User(5, "Reginaldo Frederico", "P@ssw0rd!", "Male", "Crackers", "Inmate", true),
            new User(6, "Adina Crossland", "P@ssw0rd!", "Female", "Two Tricks", "Inmate", true),
            new User(7, "Fidenziano Pata", "P@ssw0rd!", "Male", "Three Fingers", "Inmate", true),
            new User(8, "Caterina Chumley", "P@ssw0rd!", "Female", "Meatball", "Inmate", true),
            new User(9, "Tristian Perito", "P@ssw0rd!", "Male", "Tall Guy", "Inmate", true),
            new User(10, "Trenton Crupper", "P@ssw0rd!", "Male", "Nightmare", "Inmate", true),
            new User(11, "Candido Cosgrave", "P@ssw0rd!", "Male", "Moneybags", "Inmate", true),
            new User(12, "Darrin Claybrook", "P@ssw0rd!", "Male", "The Jester", "Inmate", true),
            new User(13, "Ponzio Sack", "P@ssw0rd!", "Male", "The Suit", "Inmate", true),
            new User(14, "Climaco Pressman", "P@ssw0rd!", "Male", "Cheater", "Inmate", true),
            new User(15, "Gary Holifield", "P@ssw0rd!", "Male", "Tommy Gun", "Inmate", true),
        };

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(int userId)
        {
            var selectedUser = _users.Find(user => user.Id == userId);
            return selectedUser;
        }

        public User AddUser(string name, string password, string gender, string nickName, string type)
        {
            var newUser = new User(name, password, gender, nickName, type)
            {
                Id = _users.Count + 1,
                ActiveMember = true
            };
            _users.Add(newUser);

            return newUser;
        }
    }
}
