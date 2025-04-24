using CrossCuttingConcerns.PagingSorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.Repositories;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.Crud
{
    public interface IVacancyCompleteCrud
    {
        Task CreateVacancyComplete(BOVacancyComplete bo);

        Task UpdateVacancyComplete(BOVacancyComplete bo);

        Task<List<BOVacancyComplete>> GetAllVacancies();

        Task<PaginatedList<BOVacancyComplete>> GetList(int? pageNumber, string sortField, string sortOrder, int? pageSize);

        Task<PaginatedList<BOVacancyComplete>> GetFilteredList(int? pageNumber, string sortField, string sortOrder, int? pageSize, BOActiveSearchFilter filters);

        Task<List<BOVacancyComplete>> GetAllVacanciesByCompany(int[] organizationIds);

        Task<BOVacancyComplete> GetVacancyCompleteById(int id);

        Task DeleteVacancyComplete(int id);
    }

}
