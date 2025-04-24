using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.Crud
{
    public interface ISearchFilterCrud
    {

        Task<BOSearchFilter> GetSearchFiltersTalents();

        Task<BOSearchFilter> GetSearchFiltersVacancies();

    }

}
