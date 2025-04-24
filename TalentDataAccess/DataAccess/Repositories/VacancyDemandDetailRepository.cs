using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.Repositories
{
    public interface IVacancyDemandDetailRepository
    {
        Task<VacancyDemandDetail?> GetById(int id);

        Task Delete(int id);
    }

    public class VacancyDemandDetailRepository : IVacancyDemandDetailRepository
    {
        private readonly TalentDbContext _dbContext;

        public VacancyDemandDetailRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<VacancyDemandDetail?> GetById(int id)
        {
            return await _dbContext.VacancyDemandDetails.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        public async Task Delete(int id)
        {
            var record = await GetById(id);

            if (record != null)
            {
                _dbContext.VacancyDemandDetails.Remove(record);
                await _dbContext.SaveChangesAsync();
            }
        }
    }

}
