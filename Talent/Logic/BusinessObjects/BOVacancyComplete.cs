using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOVacancyComplete
    {

        public int? Id { get; set; }

        public string Title { get; set; }

        public string Region { get; set; }

        public BOVacancyOffer VacancyOffer { get; set; }
        public BOVacancyDemand VacancyDemand { get; set; }
        public BOCompany Company { get; set; }

        public BOVacancyDemandDetail VacancyDemandDetail { get; set; }

        public BOVacancyText VacancyText { get; set; }

        public bool IsEnabled { get; set; }

        public string Created { get; set; } = string.Empty;

    }

}
