using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOVacancyDemand
    {

        public int? Id { get; set; }

        public decimal HoursMin { get; set; }

        public decimal HoursMax { get; set; }

        public string HourType { get; set; }

        public string EducationLevel { get; set; }

        public string SkillLevel { get; set; }

    }
}
