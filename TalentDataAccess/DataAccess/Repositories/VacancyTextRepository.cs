using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.Repositories
{
    public interface IVacancyTextRepository
    {
        Task<VacancyText?> GetById(int id);

        Task Delete(int id);
    }

    public class VacancyTextRepository : IVacancyTextRepository
    {
        private readonly TalentDbContext _dbContext;

        public VacancyTextRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<VacancyText?> GetById(int id)
        {
            return await _dbContext.VacancyTexts.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        public async Task Delete(int id)
        {
            var record = await GetById(id);

            if (record != null)
            {
                _dbContext.VacancyTexts.Remove(record);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
