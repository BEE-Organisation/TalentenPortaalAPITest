using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.Repositories
{

    public interface IEducationDetailRepository
    {
        Task<List<EducationDetail>> GetAll();

        Task<List<EducationDetail>> GetAllById(int id);

        Task Create(List<EducationDetail> data);

        Task Delete(int id);

        Task Update(int id, List<EducationDetail> data);

    }

    public class EducationDetailRepository : IEducationDetailRepository
    {
        private readonly TalentDbContext _dbContext;

        public EducationDetailRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<EducationDetail>> GetAll()
        {
            return await _dbContext.EducationDetails.AsNoTracking().ToListAsync();
        }

        public async Task<List<EducationDetail>> GetAllById(int id)
        {
            return await _dbContext.EducationDetails.AsNoTracking().Where(x => x.TalentId == id).ToListAsync();
        }

        public async Task Create(List<EducationDetail> data)
        {
            await _dbContext.EducationDetails.AddRangeAsync(data);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var records = await GetAllById(id);

            if (records != null)
            {
                foreach (var record in records)
                {
                    _dbContext.EducationDetails.Remove(record);
                }

                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Update(int id, List<EducationDetail> data)
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
