using CrossCuttingConcerns.EntityFrameworkGenerics;
using CrossCuttingConcerns.PagingSorting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.Repositories
{

    public interface ITalentRefactoredRepository
    {
        Task<Talent?> GetById(int id);

        Task<Talent?> GetByIdAndOrganization(int id, int organization);

        Task<List<Talent>> GetAll();

        Task<List<Talent>> GetAllByIds(List<int> ids, int organization);

        Task<PaginatedList<Talent>> GetList(int? pageNumber, string sortField, string sortOrder, int? pageSize, int organization);

        Task<PaginatedList<Talent>> GetFilteredList(ActiveSearchFilter filters, int? pageNumber, string sortField, string sortOrder, int? pageSize, int organization);

        Task<int> CountRecords();

        Task Create(Talent entity);

        Task<int> CreateNew(Talent entity);

        Task Update(int id, Talent entity);

        Task Delete(int id);
    }

    public class TalentRefactoredRepository : ITalentRefactoredRepository, IGenericRepository<Talent>
    {
        private readonly TalentDbContext _dbContext;
        private const int PageSize = 10;

        public TalentRefactoredRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Talent>> GetAll()
        {
            return await _dbContext.Talents
                .AsNoTracking()
                .Include(x => x.TalentPropertyMainCategoryLinks)
                .ThenInclude(x => x.TalentPropertySubCategoryLinks.OrderBy(x => x.Order))
                    .ThenInclude(x => x.SkillType)
                .OrderByDescending(x => x.Id)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<Talent?> GetById(int id)
        {
            return await _dbContext.Talents
                .AsNoTracking()
                .Include(x => x.TalentPropertyMainCategoryLinks)
                .ThenInclude(x => x.TalentPropertySubCategoryLinks.OrderBy(x => x.Order))
                    .ThenInclude(x => x.SkillType)
                .SingleOrDefaultAsync(x => x.Id == id)
                .ConfigureAwait(false);
        }       

        public async Task<PaginatedList<Talent>> GetList(int? pageNumber, string sortField, string sortOrder, int? pageSize, int organization)
        {
            int? targetOrganization = (organization > 0) ? organization : null;

            IQueryable <Talent> query = _dbContext.Talents
                .AsNoTracking()
                .Include(x => x.TalentPropertyMainCategoryLinks)
                .ThenInclude(x => x.TalentPropertySubCategoryLinks.OrderBy(x => x.Order))
                    .ThenInclude(x => x.SkillType)
                .Where(x => x.IsProfileVisible && x.FoundJob == false)
                .Where(x => x.OrganisationId == targetOrganization)
                .OrderByDescending(x => x.Id);

            return await PaginatedList<Talent>.CreateAsync(query, pageNumber ?? 1, pageSize ?? PageSize, sortField ?? "Id", sortOrder ?? "ASC");
        }
        
        IQueryable<Talent> IGenericRepository<Talent>.GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<int> CountRecords()
        {
            return await _dbContext.Talents
                .Select(x => x.Id)
                .CountAsync()
                .ConfigureAwait(false);
        }

        public async Task Create(Talent entity)
        {
            await _dbContext.Talents.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<int> CreateNew(Talent entity)
        {
            await _dbContext.Talents.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task Delete(int id)
        {
            var record = await GetById(id);

            if(record != null)
            {
                _dbContext.Talents.Remove(record);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Update(int id, Talent entity)
        {
            var record = await GetById(id);

            if(record != null)
            {
                record = entity;
                _dbContext.Talents.Update(record);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<Talent?> GetByIdAndOrganization(int id, int organization)
        {
            int? targetOrganization = (organization > 0) ? organization : null;

            return await _dbContext.Talents
                .AsNoTracking()
                .Include(x => x.TalentPropertyMainCategoryLinks)
                .ThenInclude(x => x.TalentPropertySubCategoryLinks.OrderBy(x => x.Order))
                    .ThenInclude(x => x.SkillType)
                .SingleOrDefaultAsync(x => x.Id == id && x.IsProfileVisible && x.OrganisationId == targetOrganization)
                .ConfigureAwait(false);
        }

        public async Task<PaginatedList<Talent>> GetFilteredList(ActiveSearchFilter filters, int? pageNumber, string sortField, string sortOrder, int? pageSize, int organization)
        {
            int? targetOrganization = (organization > 0) ? organization : null;

            List<int> activeProfiles = await _dbContext.Talents.Where(x => x.IsProfileVisible && x.FoundJob == false).Select(x => x.Id).ToListAsync().ConfigureAwait(false);
            List<int> filterCategoriesByTalentId = new List<int>();

            if (filters.FilterProperties.Count() > 0)
            {
                var subCategories = await _dbContext.TalentPropertySubCategoryLinks
                    .Where(x => filters.FilterProperties.Contains(x.TalentPropertyLabelId))
                    .Select(x => x.TalentPropertyMainCategoryLink.Id)
                    .Distinct()
                    .ToListAsync()
                    .ConfigureAwait(false);

                filterCategoriesByTalentId = await _dbContext.TalentPropertyMainCategoryLinks
                    .Where(x => activeProfiles.Contains(x.TalentId) && subCategories.Contains(x.Id))
                    .Select(x => x.TalentId)
                    .Distinct()
                    .ToListAsync()
                    .ConfigureAwait(false);
            }

            IQueryable<Talent> query = _dbContext.Talents
                .Include(x => x.TalentPropertyMainCategoryLinks)
                .ThenInclude(x => x.TalentPropertySubCategoryLinks.OrderBy(x => x.Order))
                    .ThenInclude(x => x.SkillType);

            if (filters.Provinces.Count() > 0)
            {
                query = query.Where(x => filters.Provinces.Contains(x.Province));
            }

            if (filters.EducationLevels.Count() > 0)
            {
                query = query.Where(x => filters.EducationLevels.Contains(x.Education));
            }

            if (filters.AvailableHoursMin != 8)
            {
                //query = query.Where(x = x > filters.AvailableHoursMin >= (decimal) filters.AvailableHoursMin);
                query = query.Where(x => x.AvailableHours >= filters.AvailableHoursMin);
            }

            if (filters.AvailableHoursMax != 40)
            {
                //query = query.Where(x => filters.AvailableHoursMin <= (decimal) filters.AvailableHoursMax);
                query = query.Where(x => x.AvailableHours <= filters.AvailableHoursMax);
            }

            if (filters.WorkLocations.Count() > 0)
            {
                query = query.Where(x => filters.WorkLocations.Contains(x.DesiredWorkLocation));
            }

            if (filters.TravelDistance > 0)
            {
                //query = query.Where(x => filters.TravelDistance > filters.TravelDistance);
                query = query.Where(x => x.TravelDistance <= filters.TravelDistance);
            }

            if(activeProfiles.Count() > 0 && filterCategoriesByTalentId.Count() > 0)
            {
                query = query.Where(x => activeProfiles.Contains(x.Id) && filterCategoriesByTalentId.Contains(x.Id));
            }
            else
            {
                query = query.Where(x => x.IsProfileVisible == true);
            }

            query = query.Where(x => x.OrganisationId == targetOrganization);
            query = query.OrderByDescending(x => x.Id);

            return await PaginatedList<Talent>.CreateAsync(query.AsNoTracking(), pageNumber ?? 1, pageSize ?? PageSize, sortField ?? "Id", sortOrder ?? "ASC");
        }

        public async Task<List<Talent>> GetAllByIds(List<int> ids, int organization)
        {
            int? targetOrganization = (organization > 0) ? organization : null;

            return await _dbContext.Talents
                .AsNoTracking()
                .Include(x => x.TalentPropertyMainCategoryLinks)
                .ThenInclude(x => x.TalentPropertySubCategoryLinks.OrderBy(x => x.Order))
                    .ThenInclude(x => x.SkillType)
                .OrderByDescending(x => x.Id)
                .Where(x => ids.Contains(x.Id) && x.OrganisationId == targetOrganization && x.IsProfileVisible == true && x.FoundJob == false)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
