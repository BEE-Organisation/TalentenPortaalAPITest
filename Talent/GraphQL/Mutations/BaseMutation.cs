using System.Threading.Tasks;
using TalentLogic.GraphQL.Repositories;

namespace TalentLogic.GraphQL.Mutations;

public class BaseMutation<TModel, TKey> where TModel : class, new()
{
    public virtual Task<TModel> Insert(TModel entity, IGenericGraphQLRepository<TModel, TKey> repository)
    {
        return repository.Insert(entity);
    }

    public virtual Task<TModel> Update(TModel entity, TKey id, IGenericGraphQLRepository<TModel, TKey> repository)
    {
        return repository.Update(entity, id);
    }

    public virtual Task<bool> Delete(TKey id, IGenericGraphQLRepository<TModel, TKey> repository)
    {
        return repository.Delete(id);
    }
}