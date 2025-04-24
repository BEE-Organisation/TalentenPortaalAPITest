using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.ExampleData
{
    public class CreateVacancyDemandDetails
    {

        public static List<VacancyDemandDetail> Create()
        {

            return new List<VacancyDemandDetail>()
            {
                new VacancyDemandDetail()
                {
                    Id =1,
                    ParentProperties = new int[] { 1, 2, 3, 5, 6 },
                    ChildProperties = new int[] { 15, 20, 21, 26, 56, 55, 66 }
                },
                new VacancyDemandDetail()
                {
                    Id = 2,
                    ParentProperties = new int[] { 1, 2, 3, 4, 5, 6, 8 },
                    ChildProperties = new int[] { 10, 11, 12, 15, 20, 21, 22, 27, 28, 40, 41, 49, 68, 88, 89, 90, 94 }
                },
                new VacancyDemandDetail()
                {
                    Id = 3,
                    ParentProperties = new int[] { 2, 3, 4, 5, 6, 8 },
                    ChildProperties = new int[] { 20, 21, 27, 28, 41, 55, 56, 66, 88, 89, 94, 98, 110 }
                }
            };
        }
    }

}
