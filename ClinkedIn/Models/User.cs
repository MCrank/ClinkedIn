using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Models
{
    public class User
    {

        public User(string name, string password, string gender, string nickName, string type)
        {
            Name = name;
            Password = password;
            Gender = gender;
            NickName = nickName;
            Type = type;
        }

        public User(int id, string name, string password, string gender, string nickName, string type, bool active)
        {
            Id = id;
            Name = name;
            Password = password;
            Gender = gender;
            NickName = nickName;
            Type = type;
            ActiveMember = active;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string NickName { get; set; }
        public string Type { get; set; }
        public bool ActiveMember { get; set; }

    }
}
