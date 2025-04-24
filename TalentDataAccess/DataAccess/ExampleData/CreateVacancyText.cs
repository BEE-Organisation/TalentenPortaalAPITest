using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.ExampleData
{
    public class CreateVacancyText
    {

        public static List<VacancyText> Create()
        {
            return new List<VacancyText>()
            {
                 new VacancyText() { 
                    Id = 1,
                    Text = "De Gemeente Dinodrecht zoekt een beginnende tester.",
                    ShowCompanyInfo = true
                },
                 new VacancyText()
                {
                    Id = 2,
                    Text = "White Seals IT Detachering is op zoek naar een Senior C# programmeur.",
                    ShowCompanyInfo = true
                },
                new VacancyText()
                {
                    Id = 3,
                    Text = "Het WVU werkbedrijf biedt een stage aan voor een Frontend programmeur Angular.",
                    ShowCompanyInfo = true
                }
            };
        }

    }
}
