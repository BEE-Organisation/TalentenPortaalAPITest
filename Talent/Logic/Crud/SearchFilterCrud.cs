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
    public class SearchFilterCrud : ISearchFilterCrud
    {
        private readonly ISearchFilterRepository _searchFilterRepository;
        private readonly ITalentPropertyLabelRepository _talentPropertyLabelRepository;

        public SearchFilterCrud(
            ISearchFilterRepository searchFilterRepository,
            ITalentPropertyLabelRepository talentPropertyLabelRepository
        )
        {
            _searchFilterRepository = searchFilterRepository;
            _talentPropertyLabelRepository = talentPropertyLabelRepository;
        }

        public async Task<BOSearchFilter> GetSearchFiltersTalents()
        {
            try
            {
                BOSearchFilter searchFilters = new BOSearchFilter();
                searchFilters.Provinces = await _searchFilterRepository.GetDistinctProvinces(true);
                searchFilters.EducationLevels = await _searchFilterRepository.GetDistinctEducationLevels(true);
                searchFilters.WorkLocations = await _searchFilterRepository.GetDistinctDesiredWorkLocations();

                List<int> properties = await _searchFilterRepository.GetDistinctCategoriesTalents();
                List<TalentPropertyLabel> allLabels = await _talentPropertyLabelRepository.GetAll();

                List<BOTalentPropertyLabel> filterProperties = new List<BOTalentPropertyLabel>();

                foreach (var property in properties)
                {
                    TalentPropertyLabel? label = SearchLabel(property, allLabels);

                    if (label != null)
                    {
                        filterProperties.Add(TalentPropertyLabelMapper.Map(label));
                    }
                }

                searchFilters.Properties = filterProperties;


                return searchFilters;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);                
            }            
        }

        public async Task<BOSearchFilter> GetSearchFiltersVacancies()
        {
            try
            {
                BOSearchFilter searchFilters = new BOSearchFilter();
                searchFilters.Provinces = await _searchFilterRepository.GetDistinctProvinces(false);
                searchFilters.EducationLevels = await _searchFilterRepository.GetDistinctEducationLevels(false);
                searchFilters.SkillLevels = await _searchFilterRepository.GetDistinctSkillLevels();
                searchFilters.Companies = await _searchFilterRepository.GetDistinctCompanies();

                List<int> properties = await _searchFilterRepository.GetDistinctCategoriesVacancies();
                List<TalentPropertyLabel> allLabels = await _talentPropertyLabelRepository.GetAll();

                List<BOTalentPropertyLabel> filterProperties = new List<BOTalentPropertyLabel>();

                foreach (var property in properties)
                {
                    TalentPropertyLabel? label = SearchLabel(property, allLabels);

                    if (label != null)
                    {
                        filterProperties.Add(TalentPropertyLabelMapper.Map(label));
                    }
                }

                searchFilters.Properties = filterProperties;


                return searchFilters;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private TalentPropertyLabel? SearchLabel(int id, List<TalentPropertyLabel> labels)
        {
            foreach(var label in labels)
            {
                if(label.Id == id)
                {
                    return label;
                }
            }

            return null;
        }

    }

}
