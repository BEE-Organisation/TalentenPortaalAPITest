using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.Repositories;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.Crud.ReadOnly;
using TalentLogic.Logic.ObjectMappers;

namespace TalentLogic.Logic.Crud
{
    public class TalentPropertyLabelCrud : ITalentPropertyLabelCrud
    {
        private readonly ITalentPropertyLabelRepository _talentPropertyLabelRepository;

        public TalentPropertyLabelCrud(
            ITalentPropertyLabelRepository talentPropertyLabelRepository
        )
        {
            _talentPropertyLabelRepository = talentPropertyLabelRepository;
        }

        public async Task CreateLabel(BOTalentPropertyLabel bo)
        {
            await _talentPropertyLabelRepository.Create(TalentPropertyLabelMapper.Map(bo));
        }

        public async Task DeleteLabel(int id)
        {
            await _talentPropertyLabelRepository.Delete(id);
        }

        public async Task<List<BOTalentPropertyLabel>> GetAllLabels()
        {
            var items = await _talentPropertyLabelRepository.GetAll();

            List<BOTalentPropertyLabel> list = new List<BOTalentPropertyLabel>();

            foreach(var item in items)
            {
                list.Add(TalentPropertyLabelMapper.Map(item));
            }

            return list;
        }

        public async Task UpdateLabel(BOTalentPropertyLabel bo)
        {
            await _talentPropertyLabelRepository.Update(TalentPropertyLabelMapper.Map(bo));
        }

    }
}
