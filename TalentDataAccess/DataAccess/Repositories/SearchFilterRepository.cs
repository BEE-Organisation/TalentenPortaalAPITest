using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.Repositories
{

    public interface ISearchFilterRepository
    {
        Task<List<string>> GetDistinctProvinces(bool isTalentsPage);

        Task<List<string>> GetDistinctEducationLevels(bool isTalentsPage);

        Task<List<string>> GetDistinctDesiredWorkLocations();

        Task<List<int>> GetDistinctCategoriesTalents();

        Task<List<int>> GetDistinctCategoriesVacancies();

        Task<List<string>> GetDistinctSkillLevels();

        Task<List<string>> GetDistinctCompanies();

    }

    public class SearchFilterRepository : ISearchFilterRepository
    {

        private readonly TalentDbContext _dbContext;

        public SearchFilterRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<string>> GetDistinctDesiredWorkLocations()
        {
            return await _dbContext.Talents
                .Where(x => x.IsProfileVisible)
                .OrderBy(x => x.DesiredWorkLocation)
                .Select(x => x.DesiredWorkLocation)
                .Distinct()                
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<List<string>> GetDistinctEducationLevels(bool isTalentsPage)
        {
            if(isTalentsPage)
            {
                return await _dbContext.Talents
                    .Where(x => x.IsProfileVisible)
                    .OrderBy(x => x.Education)
                    .Select(x => x.Education)
                    .Distinct()
                    .ToListAsync()
                    .ConfigureAwait(false);
            }
            else
            {
                return await _dbContext.Vacancies
                    .Include(x => x.VacancyDemand)
                    .Where(x => x.IsEnabled)                                      
                    .OrderBy(x => x.VacancyDemand.EducationLevel)
                    .Select(x => x.VacancyDemand.EducationLevel)
                    .Distinct()
                    .ToListAsync()
                    .ConfigureAwait(false);
            }
            
        }

        public async Task<List<string>> GetDistinctProvinces(bool isTalentsPage)
        {
            if(isTalentsPage)
            {
                return await _dbContext.Talents
                    .Where(x => x.IsProfileVisible)
                    .OrderBy(x => x.Province)
                    .Select(x => x.Province)
                    .Distinct()
                    .ToListAsync()
                    .ConfigureAwait(false);
            }
            else
            {
                return await _dbContext.Vacancies
                    .Where(x => x.IsEnabled)
                    .OrderBy(x => x.Region)
                    .Select(x => x.Region)
                    .Distinct()
                    .ToListAsync()
                    .ConfigureAwait(false);
            }            
        }

        public async Task<List<int>> GetDistinctCategoriesTalents()
        {
            var activeTalents = await _dbContext.Talents
                 .Where(x => x.IsProfileVisible)
                 .Select(x => x.Id)
                 .ToListAsync()
                 .ConfigureAwait(false);

            List<int> distinctMainCategories = await _dbContext.TalentPropertyMainCategoryLinks
                .Where(x => activeTalents.Contains(x.TalentId))
                .OrderBy(x => x.TalentPropertyLabelId)
                .Select(x => x.TalentPropertyLabelId)
                .Distinct()
                .ToListAsync()
                .ConfigureAwait(false);

            var activeMainCategories = await _dbContext.TalentPropertyMainCategoryLinks
                .Where(x => activeTalents.Contains(x.TalentId))
                .Select(x => x.Id)
                .ToListAsync()
                .ConfigureAwait(false);

            List<int> distinctSubCategories = await _dbContext.TalentPropertySubCategoryLinks
                .Where(x => activeMainCategories.Contains(x.TalentPropertyMainCategoryLink.Id))
                .OrderBy(x => x.TalentPropertyLabelId)
                .Select(x => x.TalentPropertyLabelId)
                .Distinct()
                .ToListAsync()
                .ConfigureAwait(false);

            List<int> distinct = new List<int>();
            distinct.AddRange(distinctMainCategories);
            distinct.AddRange(distinctSubCategories);

            return distinct;
        }

        public async Task<List<string>> GetDistinctSkillLevels()
        {
            return await _dbContext.Vacancies
                   .Include(x => x.VacancyDemand)
                   .Where(x => x.IsEnabled)
                   .OrderBy(x => x.VacancyDemand.SkillLevel)
                   .Select(x => x.VacancyDemand.SkillLevel)
                   .Distinct()
                   .ToListAsync()
                   .ConfigureAwait(false);
        }

        public async Task<List<string>> GetDistinctCompanies()
        {
            return await _dbContext.Vacancies
                .Include(x => x.Company)
                .Where(x => x.IsEnabled)
                .OrderBy(x => x.Company.Name)
                .Select(x => x.Company.Name)
                .Distinct()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<List<int>> GetDistinctCategoriesVacancies()
        {
            List<int> ids = new List<int>();

            var items = await _dbContext.Vacancies
                .Include(x => x.VacancyDemandDetail)
                .Where(x => x.IsEnabled)
                .ToListAsync()
                .ConfigureAwait(false);

            foreach(var item in items)
            {
                int[] parentIds = item.VacancyDemandDetail.ParentProperties;
                int[] childIds = item.VacancyDemandDetail.ChildProperties;

                foreach(int parentId in parentIds)
                {
                    if(!ids.Contains(parentId))
                    {
                        ids.Add(parentId);
                    }
                }

                foreach(int childId in childIds)
                {
                    if (!ids.Contains(childId))
                    {
                        ids.Add(childId);
                    }
                }
            }

            return ids;
        }
    }

}
