using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject
{
    [DataContract]

    public class LevelStats
    {

        [DataMember]
        public string Name { get; set; }

        [DataMember] 
        public int TimePassed { get; set; }
        [DataMember]
        public int Coins { get; set; }

        [DataMember]
        public int NumberOfCoins{ get; set; }

        [DataMember]
        public int TimeClicked { get; set; }
        
        [DataMember]
        public int LevelId { get; set; }

        [DataMember]
        public int Id { get; set; }

       
        public LevelStats(string name, int timePassed, int coins, int numberOfCoins, int timeClicked, int levelId,int id=0)
        {
            Name = name;
            TimePassed = timePassed;
            Coins = coins;
            NumberOfCoins = numberOfCoins;
            TimeClicked = timeClicked;
            LevelId = levelId;
            Id = id;
        }


    }
}
