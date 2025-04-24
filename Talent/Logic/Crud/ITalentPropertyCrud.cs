using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.Crud
{
    public interface ITalentPropertyCrud
    {

        Task CreateTalentProperties(List<BOTalentPropertyMainCategory> entities);

        Task CreateTalentProperty(BOTalentPropertyMainCategory entity);

        Task<List<BOTalentPropertyMainCategory>> GetAllByTalentId(int talentId);

        Task UpdateTalentProperties(List<BOTalentPropertyMainCategory> entities);

        Task UpdateTalentProperty(BOTalentPropertyMainCategory entity);

    }

}
