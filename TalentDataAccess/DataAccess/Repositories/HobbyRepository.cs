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
    public interface IHobbyRepository
    {
        Task<List<Hobby>> GetAll();

        Task<List<Hobby>> GetAllById(int id);

        Task Create(List<Hobby> data);

        Task Delete(int id);

        Task Update(int id, List<Hobby> data);
    }

    public class HobbyRepository : IHobbyRepository
    {

        private readonly TalentDbContext _dbContext;

        public HobbyRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Hobby>> GetAll()
        {
            return await _dbContext.Hobbies.AsNoTracking().ToListAsync();
        }

        public async Task<List<Hobby>> GetAllById(int id)
        {
            return await _dbContext.Hobbies.AsNoTracking().Where(x => x.TalentId == id).ToListAsync();
        }

        public async Task Create(List<Hobby> data)
        {
            await _dbContext.Hobbies.AddRangeAsync(data);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var records = await _dbContext.Hobbies.Where(x => x.TalentId == id).ToListAsync();

            if (records != null)
            {
                foreach (var record in records)
                {
                    _dbContext.Hobbies.Remove(record);
                }

                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Update(int id, List<Hobby> data)
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
