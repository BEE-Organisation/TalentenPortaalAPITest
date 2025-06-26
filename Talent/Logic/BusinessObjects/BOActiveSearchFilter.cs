using System.Collections.Generic;

namespace TalentDataAccess.DataAccess.Repositories
{
    public class BOActiveSearchFilter
    {

        public List<string> Provinces { get; set; } = new List<string>();

        public List<string> EducationLevels { get; set; } = new List<string>();

        public List<int> FilterProperties { get; set; } = new List<int>();

        public List<string> SkillLevels { get; set; } = new List<string>();

        public List<string> Companies { get; set; } = new List<string>();

        public List<string> LaborMarketRegions { get; set; } = new List<string>();

        public int AvailableHoursMin { get; set; } = 8;

        public int AvailableHoursMax { get; set; } = 40;

        public List<string> WorkLocations { get; set; } = new List<string>();

        public int TravelDistance { get; set; } = 0;

    }

}