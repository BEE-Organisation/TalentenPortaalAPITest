using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.Crud
{
    public interface ICompanyCrud
    {

        Task CreateCompany(BOCompany bo);

        Task UpdateCompany(BOCompany bo);

        Task<List<BOCompany>> GetAllCompanies();
        Task<List<BOCompany>> GetAllCompaniesById(string keycloakId);

        Task<BOCompany> GetCompanyById(int id);

        Task<BOCompanyDelete> DeleteCompany(int id);

    }
}
