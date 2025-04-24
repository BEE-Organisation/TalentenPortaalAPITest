using CrossCuttingConcerns.PagingSorting;
using System.Linq;
using System.Threading.Tasks;

namespace CrossCuttingConcerns.EntityFrameworkGenerics
{
    public interface IGenericRepository<TEntity>
        where TEntity : class, IEntity
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task Create(TEntity entity);
        Task Update(int id, TEntity entity);
        Task Delete(int id);
        Task<PaginatedList<TEntity>> GetList(int? pageNumber, string sortField, string sortOrder, int? pageSize, int organization = 0);
    }

    public interface IEntity
    {
        int Id { get; set; }
    }
}