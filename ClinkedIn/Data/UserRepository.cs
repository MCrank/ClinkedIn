using ClinkedIn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Data
{
    public class UserRepository
    {
        static List<User> _users = new List<User>
        {
            new User(1, "Jeremiah Ruggirello", "P@ssw0rd!", "Male", "Sweet Cakes", "Inmate", true),
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

        public List<User> GetUsers()
        {
            return _users;
        }

        public User AddUser(string name, string password, string gender, string nickName, string type)
        {
            var newUser = new User(name, password, gender, nickName, type);
            newUser.Id = _users.Count + 1;
            newUser.ActiveMember = true;
            _users.Add(newUser);

            return newUser;
        }
    }
}
