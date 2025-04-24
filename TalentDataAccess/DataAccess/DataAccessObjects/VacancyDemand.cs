using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{

    public enum HourType
    {
        UNKNOWN = 0,
        FIXED = 1,
        FLEXIBLE = 2,
        CONSULTATION = 3,
    }

    [Table("VacancyDemand", Schema = "TalentenPortaal")]
    public class VacancyDemand
    {
        [Key]
        public int Id { get; set; }

        public decimal HoursMin { get; set; }

        public decimal HoursMax { get; set; }

        public HourType HourType { get; set; }

        public string EducationLevel { get; set; } = string.Empty;

        public string SkillLevel { get; set; } = string.Empty;

    }
}
