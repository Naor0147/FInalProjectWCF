using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Mail { get; set; }
        [DataMember]
        public int YearBorn { get; set; }

        public User(string name, string password, string mail, int yearBorn)
        {
            Name = name;
            Password = password;
            Mail = mail;
            YearBorn = yearBorn;
        }
    }
}
