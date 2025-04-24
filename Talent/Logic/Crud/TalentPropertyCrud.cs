using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentDataAccess.DataAccess.Repositories;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.ObjectMappers;

namespace TalentLogic.Logic.Crud
{
    public class TalentPropertyCrud : ITalentPropertyCrud
    {

        private readonly ITalentPropertyRepository _talentPropertyRepository;

        public TalentPropertyCrud(ITalentPropertyRepository talentPropertyRepository)
        {
            _talentPropertyRepository = talentPropertyRepository;
        }

        public async Task CreateTalentProperties(List<BOTalentPropertyMainCategory> entities)
        {
            //Check labels.
            foreach (var entity in entities)
            {
                if(entity.TalentPropertyLabelId == null)
                {
                    entity.TalentPropertyLabelId = await _talentPropertyRepository.CreateLabel(TalentPropertyMapper.CreateLabel(entity.TalentPropertyLabelName, null));
                }

                if(entity.TalentPropertySubCategoryLinks.Count() > 0)
                {
                    foreach(var subCategory in entity.TalentPropertySubCategoryLinks)
                    {
                        if(subCategory.TalentPropertyLabelId == null)
                        {
                            subCategory.TalentPropertyLabelId = await _talentPropertyRepository.CreateLabel(TalentPropertyMapper.CreateLabel(subCategory.TalentPropertyLabelName, entity.TalentPropertyLabelId));
                        }
                    }
                }
            }

            List<TalentPropertyMainCategoryLink> models = new List<TalentPropertyMainCategoryLink>();

            foreach (var entity in entities)
            {
                models.Add(TalentPropertyMapper.Map(entity));
            }

            await _talentPropertyRepository.CreateRange(models);
        }

        public async Task CreateTalentProperty(BOTalentPropertyMainCategory entity)
        {
            //Check label.
            if (entity.TalentPropertyLabelId == null)
            {
                entity.TalentPropertyLabelId = await _talentPropertyRepository.CreateLabel(TalentPropertyMapper.CreateLabel(entity.TalentPropertyLabelName, null));
            }

            if (entity.TalentPropertySubCategoryLinks.Count() > 0)
            {
                foreach (var subCategory in entity.TalentPropertySubCategoryLinks)
                {
                    if (subCategory.TalentPropertyLabelId == null)
                    {
                        subCategory.TalentPropertyLabelId = await _talentPropertyRepository.CreateLabel(TalentPropertyMapper.CreateLabel(subCategory.TalentPropertyLabelName, entity.TalentPropertyLabelId));
                    }
                }
            }

            await _talentPropertyRepository.Create(TalentPropertyMapper.Map(entity));
        }

        public async Task<List<BOTalentPropertyMainCategory>> GetAllByTalentId(int talentId)
        {
            List<BOTalentPropertyMainCategory> data = new List<BOTalentPropertyMainCategory>();

            var items = await _talentPropertyRepository.GetAllByTalentId(talentId);
            List<int> labelIds = GetLabelIds(items);
            var labels = await _talentPropertyRepository.GetLabelsByIds(labelIds);

            foreach (var item in items)
            {
                data.Add(TalentPropertyMapper.Map(item, labels));
            }

            return data;
        }

        public async Task UpdateTalentProperties(List<BOTalentPropertyMainCategory> entities)
        {
            //Check labels.
            foreach (var entity in entities)
            {
                if (entity.TalentPropertyLabelId == null)
                {
                    entity.TalentPropertyLabelId = await _talentPropertyRepository.CreateLabel(TalentPropertyMapper.CreateLabel(entity.TalentPropertyLabelName, null));
                }

                if (entity.TalentPropertySubCategoryLinks.Count() > 0)
                {
                    foreach (var subCategory in entity.TalentPropertySubCategoryLinks)
                    {
                        if (subCategory.TalentPropertyLabelId == null)
                        {
                            subCategory.TalentPropertyLabelId = await _talentPropertyRepository.CreateLabel(TalentPropertyMapper.CreateLabel(subCategory.TalentPropertyLabelName, entity.TalentPropertyLabelId));
                        }
                    }
                }
            }

            //Remove previous data.
            List<int> parentCategories = new List<int>();
            List<int> subCategories = new List<int>();

            foreach (var entity in entities)
            {
                var previous = await _talentPropertyRepository.GetByTalentIdAndPropertyId(entity.TalentId, entity.TalentPropertyLabelId ?? 0);

                if (previous != null)
                {
                    parentCategories.Add(previous.Id);

                    if (previous.TalentPropertySubCategoryLinks.Count() > 0)
                    {
                        foreach (var subCategory in previous.TalentPropertySubCategoryLinks)
                        {
                            subCategories.Add(subCategory.Id);
                        }
                    }
                }
            }

            if (parentCategories.Count() > 0)
            {
                await _talentPropertyRepository.RemoveMainCategoryByIds(parentCategories);
            }

            if(subCategories.Count() > 0)
            {
                await _talentPropertyRepository.RemoveSubCategoryByIds(subCategories);
            }            

             //Create new data.
             List<TalentPropertyMainCategoryLink> models = new List<TalentPropertyMainCategoryLink>();

            foreach (var entity in entities)
            {
                models.Add(TalentPropertyMapper.Map(entity));
            }

            await _talentPropertyRepository.CreateRange(models);
        }

        public async Task UpdateTalentProperty(BOTalentPropertyMainCategory entity)
        {
            //Check label.
            if (entity.TalentPropertyLabelId == null)
            {
                entity.TalentPropertyLabelId = await _talentPropertyRepository.CreateLabel(TalentPropertyMapper.CreateLabel(entity.TalentPropertyLabelName, null));
            }

            if (entity.TalentPropertySubCategoryLinks.Count() > 0)
            {
                foreach (var subCategory in entity.TalentPropertySubCategoryLinks)
                {
                    if (subCategory.TalentPropertyLabelId == null)
                    {
                        subCategory.TalentPropertyLabelId = await _talentPropertyRepository.CreateLabel(TalentPropertyMapper.CreateLabel(subCategory.TalentPropertyLabelName, entity.TalentPropertyLabelId));
                    }
                }
            }

            //Remove previous data.
            List<int> parentCategories = new List<int>();
            List<int> subCategories = new List<int>();

            var previous = await _talentPropertyRepository.GetByTalentIdAndPropertyId(entity.TalentId, entity.TalentPropertyLabelId ?? 0);

            if(previous != null)
            {
                parentCategories.Add(previous.Id);

                if (previous.TalentPropertySubCategoryLinks.Count() > 0)
                {
                    foreach (var subCategory in previous.TalentPropertySubCategoryLinks)
                    {
                        subCategories.Add(subCategory.Id);
                    }
                }
            }
                       

            if (parentCategories.Count() > 0)
            {
                await _talentPropertyRepository.RemoveMainCategoryByIds(parentCategories);
            }

            if (subCategories.Count() > 0)
            {
                await _talentPropertyRepository.RemoveSubCategoryByIds(subCategories);
            }

            //Create new
            await _talentPropertyRepository.Create(TalentPropertyMapper.Map(entity));
        }

        private List<int> GetLabelIds(List<TalentPropertyMainCategoryLink> items)
        {
            List<int> list = new List<int>();

            foreach (var item in items)
            {
                if(!list.Contains(item.TalentPropertyLabelId))
                {
                    list.Add(item.TalentPropertyLabelId);
                }

                if(item.TalentPropertySubCategoryLinks.Count() > 0)
                {
                    foreach(var subItems in item.TalentPropertySubCategoryLinks)
                    {
                        if (!list.Contains(subItems.TalentPropertyLabelId))
                        {
                            list.Add(subItems.TalentPropertyLabelId);
                        }
                    }
                }
            }

            return list;
        }

    }

}
