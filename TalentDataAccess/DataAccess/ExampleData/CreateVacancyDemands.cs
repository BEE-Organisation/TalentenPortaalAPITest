using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.ExampleData
{
    public class CreateVacancyDemands
    {
        public static List<VacancyDemand> Create()
        {
            return new List<VacancyDemand>()
            {
                new VacancyDemand()
                {                  
                    Id = 1,
                    HoursMin = (decimal) 20.00,
                    HoursMax = (decimal) 40.00,
                    HourType = HourType.FLEXIBLE,
                    EducationLevel = "MBO",
                    SkillLevel = "Beginner"
                },
                new VacancyDemand()
                {
                    Id = 2,
                    HoursMin = (decimal)32.00,
                    HoursMax = (decimal)40.00,
                    HourType = HourType.FIXED,
                    EducationLevel = "HBO",
                    SkillLevel = "Senior"
                },
                new VacancyDemand()
                {
                    Id = 3,
                    HoursMin = (decimal)36.00,
                    HoursMax = (decimal)40.00,
                    HourType = HourType.FLEXIBLE,
                    EducationLevel = "MBO",
                    SkillLevel = "Geen"
                }
            };
        }

    }
}
