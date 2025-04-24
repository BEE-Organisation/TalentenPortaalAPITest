using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOSearchFilter
    {

        public List<string> Provinces {  get; set; } = new List<string>();

        public List<string> EducationLevels { get; set; } = new List<string>();

        public List<string> WorkLocations { get; set; } = new List<string>();

        public List<string> SkillLevels { get; set; } = new List<string>();

        public List<string> Companies { get; set; } = new List<string>();

        public List<BOTalentPropertyLabel> Properties { get; set; }

    }
}
