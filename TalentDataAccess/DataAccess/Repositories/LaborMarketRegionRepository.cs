using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.Repositories
{
    public interface ILaborMarketRegionRepository
    {
        Task<List<LaborMarketRegion>> GetAll();

        Task<LaborMarketRegion> GetById(int id);
    }

    public class LaborMarketRegionRepository : ILaborMarketRegionRepository
    {

        private readonly TalentDbContext _dbContext;

        public LaborMarketRegionRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<LaborMarketRegion>> GetAll()
        {
            return await _dbContext.LaborMarketRegions.AsNoTracking().ToListAsync();
        }

        public async Task<LaborMarketRegion> GetById(int id)
        {
            return await _dbContext.LaborMarketRegions.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
