using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject.classes
{
    [DataContract]

    public  class CompletedLevelsQuery
    {

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int YearBorn { get; set; }
        [DataMember]
        public int CompletedLevels { get; set; }

        [DataMember]
        public int TotalTimePassed { get; set; }
        [DataMember]
        public int NumberOfCoinsCollected { get; set; }

        public CompletedLevelsQuery(string name, int yearBorn, int completedLevels, int totalTimePassed, int numberOfCoinsCollected)
        {
            Name = name;
            YearBorn = yearBorn;
            CompletedLevels = completedLevels;
            TotalTimePassed = totalTimePassed;
            NumberOfCoinsCollected = numberOfCoinsCollected;
        }
    }
}
