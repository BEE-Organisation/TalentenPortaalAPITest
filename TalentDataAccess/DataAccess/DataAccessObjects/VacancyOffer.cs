using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{
    public enum SalaryType
    {
        UNKNOWN = 0,
        FIXED = 1,
        FLEXIBLE = 2,
        CONSULTATION = 3,
        FROM = 4,
        UNTIL = 5,
        FROM_UNTIL = 6,
    }

    public enum ContractType
    {
        UNKNOWN = 0,
        FIXED = 1,
        NOT_FIXED = 2,
        FLEXIBLE = 3,
        TEMPORARY = 4,
        INTERNSHIP = 5
    }


    [Table("VacancyOffer", Schema = "TalentenPortaal")]
    public class VacancyOffer
    {
        [Key]
        public int Id { get; set; }

        public decimal SalaryMin { get; set; }

        public decimal SalaryMax { get; set; }

        public SalaryType SalaryType { get; set; }

        public int MonthsMin { get; set; }

        public int MonthsMax { get; set; }

        //ContractType has a relation with: MonthsMin & MonthsMax
        public ContractType ContractType { get; set; }

        //SecondaryConditions = properties.
        public int[] SecondaryConditions { get; set; } = new int[] { };

    }

}
