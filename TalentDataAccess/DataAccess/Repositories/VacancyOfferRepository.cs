using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.Repositories
{

    public interface IVacancyOfferRepository
    {
        Task<VacancyOffer?> GetById(int id);

        Task Delete(int id);
    }

    public class VacancyOfferRepository : IVacancyOfferRepository
    {
        private readonly TalentDbContext _dbContext;
        
        public VacancyOfferRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<VacancyOffer?> GetById(int id)
        {
            return await _dbContext.VacancyOffers.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        public async Task Delete(int id)
        {
            var record = await GetById(id);

            if(record != null)
            {
                _dbContext.VacancyOffers.Remove(record);
                await _dbContext.SaveChangesAsync();
            }
        }
        
    }
}
