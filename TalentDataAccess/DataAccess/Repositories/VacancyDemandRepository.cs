using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.Repositories
{
    public interface IVacancyDemandRepository
    {
        Task<VacancyDemand?> GetById(int id);

        Task Delete(int id);
    }

    public class VacancyDemandRepository : IVacancyDemandRepository
    {
        private readonly TalentDbContext _dbContext;

        public VacancyDemandRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<VacancyDemand?> GetById(int id)
        {
            return await _dbContext.VacancyDemands.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        public async Task Delete(int id)
        {
            var record = await GetById(id);

            if (record != null)
            {
                _dbContext.VacancyDemands.Remove(record);
                await _dbContext.SaveChangesAsync();
            }
        }
    }

}
