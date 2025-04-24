using CrossCuttingConcerns.PagingSorting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.Repositories
{
    public interface IVacancyCompleteRepository
    {
        Task<List<VacancyComplete>> GetAll();

        Task<List<VacancyComplete>> GetAllByOrganization(List<int> organizationIds);

        Task<PaginatedList<VacancyComplete>> GetList(int? pageNumber, string sortField, string sortOrder, int? pageSize);

        Task<PaginatedList<VacancyComplete>> GetFilteredList(ActiveSearchFilter filters, int? pageNumber, string sortField, string sortOrder, int? pageSize);

        Task<VacancyComplete?> GetById(int id);

        Task Create(VacancyComplete entity);

        Task Delete(int id);

        Task Update(int id, VacancyComplete entity);

        Task<int> CountCompanyIdInUse(int id);

        Task<int> CountVacancies();
    }

    public class VacancyCompleteRepository : IVacancyCompleteRepository
    {

        private readonly TalentDbContext _dbContext;

        private const int PageSize = 10;

        public VacancyCompleteRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<VacancyComplete>> GetAll()
        {
            return await _dbContext.Vacancies.AsNoTracking()
                .Include(x => x.Company)
                .Include(x => x.VacancyOffer)
                .Include(x => x.VacancyDemand)
                .Where(x => x.IsEnabled)
                .OrderByDescending(x => x.Id)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<VacancyComplete?> GetById(int id)
        {
            return await _dbContext.Vacancies.AsNoTracking()
                .Include(x => x.Company)
                .Include(x => x.VacancyOffer)
                .Include(x => x.VacancyDemand)
                .Include(x => x.VacancyDemandDetail)
                .Include(x => x.VacancyText)
                .SingleOrDefaultAsync(x => x.Id == id)
                .ConfigureAwait(false);
        }

        public async Task Create(VacancyComplete data)
        {
            try
            {
                await _dbContext.Vacancies.AddAsync(data);
                await _dbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }

        public async Task Delete(int id)
        {
            var record = await _dbContext.Vacancies.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);

            if (record != null)
            {
                _dbContext.Vacancies.Remove(record);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Update(int id, VacancyComplete entity)
        {
            try
            {
                var record = await _dbContext.Vacancies.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);

                if (record != null)
                {
                    record = entity;
                    _dbContext.Vacancies.Update(record);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception("Unable to update record.");
            }
        }

        public async Task<List<VacancyComplete>> GetAllByOrganization(List<int> organizationIds)
        {
            return await _dbContext.Vacancies.AsNoTracking()
                .Include(x => x.Company)
                .Include(x => x.VacancyOffer)
                .Include(x => x.VacancyDemand)
                .Include(x => x.VacancyDemandDetail)
                .Include(x => x.VacancyText)
                .Where(x => organizationIds.Contains(x.CompanyId ?? 0))
                .OrderByDescending(x => x.Id)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<PaginatedList<VacancyComplete>> GetList(int? pageNumber, string sortField, string sortOrder, int? pageSize)
        {
            IQueryable<VacancyComplete> query = _dbContext.Vacancies
            .AsNoTracking()
            .Include(x => x.Company)
            .Include(x => x.VacancyOffer)
            .Include(x => x.VacancyDemand)
            .Include(x => x.VacancyDemandDetail)
            .Include(x => x.VacancyText)
            .Where(x => x.IsEnabled)
            .OrderByDescending(x => x.Id);

            return await PaginatedList<VacancyComplete>.CreateAsync(query, pageNumber ?? 1, pageSize ?? PageSize, sortField ?? "Id", sortOrder ?? "ASC");
        }

        public async Task<PaginatedList<VacancyComplete>> GetFilteredList(ActiveSearchFilter filters, int? pageNumber, string sortField, string sortOrder, int? pageSize)
        {
            List<int> activeVacancies = await _dbContext.Vacancies.Where(x => x.IsEnabled).Select(x => x.Id).ToListAsync().ConfigureAwait(false);
            
            List<int> filterDemandDetailsIds = new List<int>();

            if (filters.FilterProperties.Count() > 0)
            {
                var demandDettails = await _dbContext.VacancyDemandDetails.Where(x => activeVacancies.Contains(x.Id)).ToListAsync().ConfigureAwait(false);

                foreach(var demandDettail in demandDettails)
                {
                    int id = demandDettail.Id;
                    int[] childIds = demandDettail.ChildProperties;

                    foreach(int childId in childIds)
                    {
                        if(filters.FilterProperties.Contains(childId) && !filterDemandDetailsIds.Contains(id))
                        {
                            filterDemandDetailsIds.Add(id);
                        }
                    }                    
                }
            }

            IQueryable<VacancyComplete> query = _dbContext.Vacancies
                .Include(x => x.Company)
                .Include(x => x.VacancyOffer)
                .Include(x => x.VacancyDemand)
                .Include(x => x.VacancyDemandDetail)
                .Include(x => x.VacancyText);

           
            if(filters.Provinces.Count() > 0)
            {
                query = query.Where(x => filters.Provinces.Contains(x.Region));
            }

            if (filters.EducationLevels.Count() > 0)
            {
                query = query.Where(x => filters.EducationLevels.Contains(x.VacancyDemand.EducationLevel));
            }

            if (filters.SkillLevels.Count() > 0)
            {
                query = query.Where(x => filters.SkillLevels.Contains(x.VacancyDemand.SkillLevel));
            }

            if (filters.Companies.Count() > 0)
            {
                query = query.Where(x => filters.Companies.Contains(x.Company.Name));
            }

            if (activeVacancies.Count() > 0 && filterDemandDetailsIds.Count() > 0)
            {
                query = query.Where(x => filterDemandDetailsIds.Contains(x.VacancyDemandDetailId ?? 0));
            }
            else
            {
                query = query.Where(x => x.IsEnabled == true);
            }

            query = query.OrderByDescending(x => x.Id);

            return await PaginatedList<VacancyComplete>.CreateAsync(query.AsNoTracking(), pageNumber ?? 1, pageSize ?? PageSize, sortField ?? "Id", sortOrder ?? "ASC");
        }

        public async Task<int> CountCompanyIdInUse(int id)
        {
            return await _dbContext.Vacancies.CountAsync(x => x.CompanyId == id);
        }

        public async Task<int> CountVacancies()
        {
            return await _dbContext.Vacancies
                .Select(x => x.Id)
                .CountAsync()
                .ConfigureAwait(false);
        }

    }

}
