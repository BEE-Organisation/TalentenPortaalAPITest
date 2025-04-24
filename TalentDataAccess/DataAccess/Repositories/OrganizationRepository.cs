using CrossCuttingConcerns.EntityFrameworkGenerics;
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
    public interface IOrganizationRepository
    {
        Task<List<Organization>> GetAll();

        Task<Organization> GetById(int id);

        Task Create(Organization entity);

        Task Delete(int id);

        Task Update(int id, Organization entity);

        Task<int> CountOrganizations();
    }

    public class OrganizationRepository : IOrganizationRepository
    {

        private readonly TalentDbContext _dbContext;

        public OrganizationRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Organization>> GetAll()
        {
            return await _dbContext.Organizations.AsNoTracking().ToListAsync();
        }

        public async Task<Organization> GetById(int id)
        {
            return await _dbContext.Organizations.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(Organization entity)
        {
            await _dbContext.Organizations.AddRangeAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var record = await _dbContext.Organizations.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);

            if (record != null)
            {
                _dbContext.Organizations.Remove(record);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Update(int id, Organization entity)
        {
            var record = await GetById(id);

            if (record != null)
            {
                record = entity;
                _dbContext.Organizations.Update(record);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<int> CountOrganizations()
        {
            return await _dbContext.Organizations
                .Select(x => x.Id)
                .CountAsync()
                .ConfigureAwait(false);
        }
    }

}
