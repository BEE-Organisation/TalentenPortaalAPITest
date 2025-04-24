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
    public interface IPastExperienceRepository
    {
        Task<List<PastExperience>> GetAll();

        Task<List<PastExperience>> GetAllById(int id);

        Task Create(List<PastExperience> data);

        Task Delete(int talentId);

        Task Update(int id, List<PastExperience> data);
    }

    public class PastExperienceRepository : IPastExperienceRepository
    {

        private readonly TalentDbContext _dbContext;

        public PastExperienceRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<PastExperience>> GetAll()
        {
            return await _dbContext.PastExperiences.AsNoTracking().ToListAsync();
        }

        public async Task<List<PastExperience>> GetAllById(int id)
        {
            return await _dbContext.PastExperiences.AsNoTracking().Where(x => x.TalentId == id).ToListAsync();
        }

        public async Task Create(List<PastExperience> data)
        {
            await _dbContext.PastExperiences.AddRangeAsync(data);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int talentId)
        {
            var records = await _dbContext.PastExperiences.Where(x => x.TalentId == talentId).ToListAsync();

            if (records != null)
            {
                foreach (var record in records)
                {
                    _dbContext.PastExperiences.Remove(record);
                }

                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Update(int id, List<PastExperience> data)
        {
            try
            {
                //First delete all
                await Delete(id);

                //Insert new data.
                if (data.Count() > 0)
                {
                    await Create(data);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception("Unable to update record.");
            }
        }

    }

}
