using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject.classes
{
    [DataContract]

    public class TimeToBeatPerUser
    {
        [DataMember]
        public string Name { get; set; }

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

        [DataMember] 
        public int RowNum {  get; set; }    

        [DataMember]
        public int YearBorn { get; set; }

        [DataMember]
        public string Mail { get; set; }

        public TimeToBeatPerUser(string name, int timePassed, int coins, int numberOfCoins, int timeClicked, int levelId, int rowNum, int yearBorn, string mail)
        {
            Name = name;
            TimePassed = timePassed;
            Coins = coins;
            NumberOfCoins = numberOfCoins;
            TimeClicked = timeClicked;
            LevelId = levelId;
            RowNum = rowNum;
            YearBorn = yearBorn;
            Mail = mail;
        }
    }
}
