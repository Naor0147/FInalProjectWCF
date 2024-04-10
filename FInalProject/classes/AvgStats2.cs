using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject.classes
{
    [DataContract]
     public class AvgStats2
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int AmountOfGames { get; set; }
        [DataMember]
        public double  AvgTimePassed { get; set; }

        [DataMember]
        public double  AvgCoins { get; set; }
        [DataMember]
        public double  AvgUnitsOfCoins { get; set;}

        [DataMember]
        public double  AvgTimeClicked{ get; set; }


        public AvgStats2(string name, int amountOfGames, double  avgTimePassed, double  avgCoins, double  avgUnitsOfCoins, double  avgTimeClicked)
        {
            Name = name;
            AmountOfGames = amountOfGames;
            AvgTimePassed = avgTimePassed;
            AvgCoins = avgCoins;
            AvgUnitsOfCoins = avgUnitsOfCoins;
            AvgTimeClicked = avgTimeClicked;
        }
    }
}
