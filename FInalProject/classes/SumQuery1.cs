using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject.classes
{
    [DataContract]

    public class SumQuery1
    {
        [DataMember]
        public string Name;

        [DataMember]
        public int GamesPlayed;

        [DataMember]
        public int TimePassed;

        [DataMember]
        public int Coins;

        [DataMember]
        public int NumberOfCoins;

        [DataMember]
        public int TimeClicked;

        [DataMember]
        public int YearBorn;

        [DataMember]
        public string Mail;
  
        public SumQuery1(string name, int gamesPlayed, int timePassed, int coins, int numberOfCoins, int timeClicked, int yearBorn, string mail)
        {
            Name = name;
            GamesPlayed = gamesPlayed;
            TimePassed = timePassed;
            Coins = coins;
            NumberOfCoins = numberOfCoins;
            TimeClicked = timeClicked;
            YearBorn = yearBorn;
            Mail = mail;
        }
    }
}
