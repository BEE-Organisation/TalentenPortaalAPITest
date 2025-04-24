using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.ExampleData
{
    public class CreateVacancyOffers
    {

        public static List<VacancyOffer> Create()
        {
            return new List<VacancyOffer>()
            {
                new VacancyOffer()
                {
                    Id = 1,
                    SalaryMin = (decimal)1000.00,
                    SalaryMax = (decimal)2500.00,
                    SalaryType = SalaryType.FIXED,
                    MonthsMin = 6,
                    MonthsMax = 12,
                    ContractType = ContractType.FLEXIBLE,
                    SecondaryConditions = new int[] { 115, 117, 118, 120 }
                },
                new VacancyOffer()
                {
                    Id = 2,
                    SalaryMin = (decimal)1250.00,
                    SalaryMax = (decimal)3000.00,
                    SalaryType = SalaryType.FIXED,
                    MonthsMin = 12,
                    MonthsMax = 12,
                    ContractType = ContractType.FIXED,
                    SecondaryConditions = new int[] { 113, 114, 116 }
                },
                new VacancyOffer()
                {
                    Id = 3,
                    SalaryMin = (decimal)0.00,
                    SalaryMax = (decimal)300.00,
                    SalaryType = SalaryType.FLEXIBLE,
                    MonthsMin = 6,
                    MonthsMax = 6,
                    ContractType = ContractType.INTERNSHIP,
                    SecondaryConditions = new int[] { 117, 118, 120 }
                }
            };
        }

    }
}
