using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.ExampleData
{
    public class CreateLaborMarketRegions
    {
        public static List<LaborMarketRegion> Create()
        {
            return new List<LaborMarketRegion>
            {
                new LaborMarketRegion { Id = 1, Name = "Groningen" },
                new LaborMarketRegion { Id = 2, Name = "Friesland" },
                new LaborMarketRegion { Id = 3, Name = "Noord-Holland (Noord)" },
                new LaborMarketRegion { Id = 4, Name = "Drenthe" },
                new LaborMarketRegion { Id = 5, Name = "Regio Zwolle" },
                new LaborMarketRegion { Id = 6, Name = "Flevoland" },
                new LaborMarketRegion { Id = 7, Name = "Zaanstreek / Waterland" },
                new LaborMarketRegion { Id = 8, Name = "Zuid-Kennemerland en IJmond" },
                new LaborMarketRegion { Id = 9, Name = "Twente" },
                new LaborMarketRegion { Id = 10, Name = "Groot Amsterdam" },
                new LaborMarketRegion { Id = 11, Name = "Veluwe Stedendriehoek" },
                new LaborMarketRegion { Id = 12, Name = "Gooi en Vechtstreek" },
                new LaborMarketRegion { Id = 13, Name = "Holland Rijnland" },
                new LaborMarketRegion { Id = 14, Name = "Midden-Utrecht" },
                new LaborMarketRegion { Id = 15, Name = "Amersfoort" },
                new LaborMarketRegion { Id = 16, Name = "FoodValley" },
                new LaborMarketRegion { Id = 17, Name = "Achterhoek" },
                new LaborMarketRegion { Id = 18, Name = "Zuid-Holland Centraal" },
                new LaborMarketRegion { Id = 19, Name = "Midden-Holland" },
                new LaborMarketRegion { Id = 20, Name = "Haaglanden" },
                new LaborMarketRegion { Id = 21, Name = "Midden-Gelderland" },
                new LaborMarketRegion { Id = 22, Name = "Rijnmond" },
                new LaborMarketRegion { Id = 23, Name = "Rivierenland" },
                new LaborMarketRegion { Id = 24, Name = "Gorinchem" },
                new LaborMarketRegion { Id = 25, Name = "Rijk van Nijmegen" },
                new LaborMarketRegion { Id = 26, Name = "Drechtsteden" },
                new LaborMarketRegion { Id = 27, Name = "Noordoost-Brabant" },
                new LaborMarketRegion { Id = 28, Name = "West-Brabant" },
                new LaborMarketRegion { Id = 29, Name = "Zeeland" },
                new LaborMarketRegion { Id = 30, Name = "Midden-Brabant" },
                new LaborMarketRegion { Id = 31, Name = "Noord-Limburg" },
                new LaborMarketRegion { Id = 32, Name = "Helmond-De Peel" },
                new LaborMarketRegion { Id = 33, Name = "Zuidoost-Brabant" },
                new LaborMarketRegion { Id = 34, Name = "Midden-Limburg" },
                new LaborMarketRegion { Id = 35, Name = "Zuid-Limburg" }
            };
        }
    }
}
