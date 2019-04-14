using ClinkedIn.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ClinkedIn.Data
{
    public class UserRepository
    {
        static List<User> _users = new List<User>
        {
            new User(1, "Jeremiah Ruggirello", "P@ssw0rd!", "Male", "Sweet Cakes", "Inmate", new DateTime(2017,03,13,20,05,34), new DateTime(2019,04,11,09,38,00), true),
            new User(2, "Varo Colombini", "P@ssw0rd!", "Female", "The Dove", "Inmate", new DateTime(2017,04,12,22,06,50), new DateTime(2019,02,09,02,59,17), true),
            new User(3, "Serenity Herrold", "P@ssw0rd!", "Female", "The Cat", "Inmate", new DateTime(2017,05,06,07,40,48), new DateTime(2019,01,07,23,52,26), false),
            new User(4, "Marco Crank", "P@ssw0rd!", "Male", "Two Toes", "Warden", new DateTime(2017,05,07,07,52,50), new DateTime(2018,12,15,17,52,02), true),
            new User(5, "Reginaldo Frederico", "P@ssw0rd!", "Male", "Crackers", "Inmate", new DateTime(2017,06,07,13,37,27), new DateTime(2018,04,04,03,08,49), true),
            new User(6, "Adina Crossland", "P@ssw0rd!", "Female", "Two Tricks", "Inmate", new DateTime(2017,06,14,23,16,50), new DateTime(2018,04,18,19,32,02), true),
            new User(7, "Fidenziano Pata", "P@ssw0rd!", "Male", "Three Fingers", "Inmate", new DateTime(2017,07,27,08,25,57), new DateTime(2018,05,13,12,52,43), true),
            new User(8, "Caterina Chumley", "P@ssw0rd!", "Female", "Meatball", "Inmate", new DateTime(2017,08,22,21,21,07), new DateTime(2018,05,20,22,28,31), true),
            new User(9, "Tristian Perito", "P@ssw0rd!", "Male", "Tall Guy", "Inmate", new DateTime(2017,10,10,15,27,22), new DateTime(2018,06,29,05,53,07), false),
            new User(10, "Trenton Crupper", "P@ssw0rd!", "Male", "Nightmare", "Inmate", new DateTime(2017,10,21,20,11,49), new DateTime(2018,07,24,06,24,20), true),
            new User(11, "Candido Cosgrave", "P@ssw0rd!", "Male", "Moneybags", "Inmate", new DateTime(2017,11,03,07,22,44), new DateTime(2018,08,11,11,20,31), true),
            new User(12, "Darrin Claybrook", "P@ssw0rd!", "Male", "The Jester", "Inmate", new DateTime(2017,11,22,06,19,52), new DateTime(2018,01,05,09,00,11), true),
            new User(13, "Ponzio Sack", "P@ssw0rd!", "Male", "The Suit", "Inmate", new DateTime(2018,09,14,22,39,05), new DateTime(2018,01,29,19,45,39), true),
            new User(14, "Climaco Pressman", "P@ssw0rd!", "Male", "Cheater", "Inmate", new DateTime(2018,10,29,14,40,44), new DateTime(2018,11,18,21,46,30), true),
            new User(15, "Gary Holifield", "P@ssw0rd!", "Male", "Tommy Gun", "Inmate", new DateTime(2018,02,08,19,36,00), new DateTime(2018,11,21,11,30,33), true),
            new User(16, "Colin White", "P@ssw0rd!", "Male", "Muscles", "Warden", new DateTime(2018,02,08,19,36,00), new DateTime(2018,11,21,11,30,33), true),
            new User(17, "Tim Harley", "P@ssw0rd!", "Male", "The Blast", "Warden", new DateTime(2018,02,08,19,36,00), new DateTime(2018,11,21,11,30,33), true),
            new User(18, "Jonathan Mohan", "P@ssw0rd!", "Male", "Mumbler", "Warden", new DateTime(2018,02,08,19,36,00), new DateTime(2018,11,21,11,30,33), true)
        };

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(int userId)
        {
            return _users.Find(user => user.Id == userId);
        }

        public int GetUserDaysRemaining(int userId)
        {
            return _users.Find(user => user.Id == userId).DaysRemaining;
        }

        public User AddUser(string name, string password, string gender, string nickName, DateTime start, DateTime end, string type)
        {
            var newUser = new User(name, password, gender, nickName, start, end, type )
            {
                Id = _users.Count + 1,
                ActiveMember = true
            };
            _users.Add(newUser);

            return newUser;
        }
    }
}
