using FInalProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject.classes
{
    [DataContract]

    public class UserAndLevel
    {
        [DataMember]
        User User { get; set; }
        [DataMember]
        LevelStats LevelStats { get; set; }
        public UserAndLevel(User user, LevelStats levelStats)
        {
            User = user;
            LevelStats = levelStats;
        }
    }
}
