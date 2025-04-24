using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.ExampleData
{
    public class CreateVacanciesComplete
    {

        public static List<VacancyComplete> Create()
        {
            List<VacancyComplete> list = new List<VacancyComplete>();

            list.Add(new VacancyComplete()
            {
                Id = 1,
                Title = "Tester",
                Region = "Landelijk",
                CompanyId = 1,
                IsEnabled = true,
                VacancyOfferId = 1,
                VacancyDemandId = 1,
                VacancyDemandDetailId = 1,
                VacancyTextId = 1,
                Created = new DateTime(2024, 4, 24)
            });

            list.Add(new VacancyComplete()
            {
                Id = 2,
                Title = "Senior C# programmeur",
                Region = "Limburg",
                CompanyId = 2,
                IsEnabled = true,
                VacancyOfferId = 2,
                VacancyDemandId = 2,
                VacancyDemandDetailId = 2,
                VacancyTextId = 2,
                Created = new DateTime(2024, 4, 25)
            });

            list.Add(new VacancyComplete()
            {
                Id = 3,
                Title = "Stage Frontend programmeur Angular",
                Region = "Noord-Brabant",
                CompanyId = 3,
                IsEnabled = true,
                VacancyOfferId = 3,
                VacancyDemandId = 3,
                VacancyDemandDetailId = 3,
                VacancyTextId = 3,
                Created = new DateTime(2024, 4, 26)
            });

            return list;
        }

    }
}
