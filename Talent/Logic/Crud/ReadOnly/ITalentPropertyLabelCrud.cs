using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.Crud.ReadOnly
{
    public interface ITalentPropertyLabelCrud
    {

        Task CreateLabel(BOTalentPropertyLabel bo);

        Task UpdateLabel(BOTalentPropertyLabel bo);

        Task DeleteLabel(int id);

        Task<List<BOTalentPropertyLabel>> GetAllLabels();

    }

}
