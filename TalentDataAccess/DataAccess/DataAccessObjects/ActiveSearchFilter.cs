using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{
    public class ActiveSearchFilter
    {
        public List<string> Provinces { get; set; } = new List<string>();

        public List<string> EducationLevels { get; set; } = new List<string>();

        public List<string> SkillLevels { get; set; } = new List<string>();

        public List<string> Companies { get; set; } = new List<string>();

        public List<int> FilterProperties { get; set; } = new List<int>();

        public int AvailableHoursMin { get; set; } = 8;

        public int AvailableHoursMax { get; set; } = 40;

        public List<string> WorkLocations { get; set; } = new List<string>();

        public int TravelDistance { get; set; } = 0;
    }

}
