using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject.classes
{
    [DataContract]

    public class AvgScore
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Mail { get; set; }
        [DataMember]
        public int YearBorn { get; set; }

        [DataMember]
        public int TimePassed { get; set; }
        [DataMember]
        public int Coins { get; set; }

        [DataMember]
        public int NumberOfCoins { get; set; }

        [DataMember]
        public int TimeClicked { get; set; }

        [DataMember]
        public int LevelId { get; set; }

        
        public AvgScore (string name, string mail, int yearBorn, int timePassed, int coins, int numberOfCoins, int timeClicked, int levelId)
        {
            Name = name;
            Mail = mail;
            YearBorn = yearBorn;
            TimePassed = timePassed;
            Coins = coins;
            NumberOfCoins = numberOfCoins;
            TimeClicked = timeClicked;
            LevelId = levelId;
        }   
    }
}
