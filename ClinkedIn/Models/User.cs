using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Models
{
    public class User
    {

        public User(string name, string password, string gender, string nickName, DateTime startSentence, DateTime endSentence, string type)
        {
            Name = name;
            Password = password;
            Gender = gender;
            NickName = nickName;
            StartSentence = startSentence;
            EndSentence = endSentence;
            Type = type;
        }

        public User(int id, string name, string password, string gender, string nickName, string type, DateTime startSentence, DateTime endSentence, bool active)
        {
            Id = id;
            Name = name;
            Password = password;
            Gender = gender;
            NickName = nickName;
            Type = type;
            StartSentence = startSentence;
            EndSentence = endSentence;
            ActiveMember = active;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string NickName { get; set; }
        public string Type { get; set; }
        public DateTime StartSentence { get; set; }
        public DateTime EndSentence { get; set; }

        public int DaysRemaining
        {
            get
            {
                return (EndSentence - StartSentence).Days;
            }
        }

        public bool ActiveMember { get; set; }
    }
}
