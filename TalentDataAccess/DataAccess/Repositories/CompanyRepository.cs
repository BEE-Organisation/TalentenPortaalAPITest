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
    public interface ICompanyRepository
    {
        Task<List<Company>> GetAll();

        Task<List<Company>> GetAllById(string keycloakId);

        Task<Company?> GetById(int id);

        Task Create(Company entity);

        Task Delete(int id);

        Task Update(Company entity);

        Task<int> CountCompanies();
    }

    public class CompanyRepository : ICompanyRepository
    {

        private readonly TalentDbContext _dbContext;

        public CompanyRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Company>> GetAll()
        {
            return await _dbContext.Companies.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        public async Task<Company?> GetById(int id)
        {
            return await _dbContext.Companies.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        public async Task Create(Company data)
        {
            await _dbContext.Companies.AddAsync(data);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var record = await _dbContext.Companies.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);

            if (record != null)
            {
                _dbContext.Companies.Remove(record);

                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Update(Company entity)
        {
            try
            {
                var record = await _dbContext.Companies.AsNoTracking().SingleOrDefaultAsync(x => x.Id == entity.Id).ConfigureAwait(false);

                if(record != null)
                {
                    record = entity;
                    _dbContext.Companies.Update(record);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception("Unable to update record.");
            }
        }

        public async Task<List<Company>> GetAllById(string keycloakId)
        {
            return await _dbContext.Companies.AsNoTracking().Where(x => x.Creator.Equals(keycloakId)).ToListAsync().ConfigureAwait(false);
        }

        public async Task<int> CountCompanies()
        {
            return await _dbContext.Companies
                .Select(x => x.Id)
                .CountAsync()
                .ConfigureAwait(false);
        }
    }

}
