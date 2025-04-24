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
    public interface ITalentRefactoredCrud
    {

        Task<BOTalentRefactored> GetById(int id);

        Task<BOTalentRefactored> GetByIdAndOrganization(int id, int organization = 0);

        Task<List<BOTalentRefactored>> GetAll();

        Task<List<BOTalentRefactored>> GetAllFavourites(int[] favourites, int organization = 0);

        Task<PaginatedList<BOTalentRefactored>> GetPagedList(int? pageNumber, string sortField, string sortOrder, int? pageSize, int organization = 0);

        Task<PaginatedList<BOTalentRefactored>> GetFilteredList(int? pageNumber, string sortField, string sortOrder, int? pageSize, BOActiveSearchFilter filters, int organization = 0);

        Task CreateTalent(BOTalentRefactored bo);

        Task UpdateTalent(BOTalentRefactored bo);

        Task DeleteTalent(int id);

    }
}
