using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.Crud.ReadOnly
{
    public interface IOrganizationCrud
    {
        Task CreateOrganization(BOOrganization bo);

        Task UpdateOrganization(BOOrganization bo);

        Task<BOOrganization> GetOrganizationById(int id);

        Task<List<BOOrganization>> GetAllOrganizations();

        Task DeleteOrganization(int id);

        Task<BOOrganizationStyle> GetOrganizationStyle(int organization = 0);
    }

}
