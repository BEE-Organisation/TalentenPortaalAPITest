using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOVacancyOffer
    {
        public int? Id { get; set; }

        public decimal SalaryMin { get; set; }

        public decimal SalaryMax { get; set; }

        public string SalaryType { get; set; }

        public int MonthsMin { get; set; }

        public int MonthsMax { get; set; }

        //ContractType has a relation with: MonthsMin & MonthsMax
        public string ContractType { get; set; }

        //Contains properties.
        public List<BOTalentPropertyLabel> SecondaryConditions { get; set; }

    }

}
