using System.Linq;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using TalentLogic.GraphQL.Repositories;

namespace TalentLogic.GraphQL.Resolvers;

public class BaseResolver<TModel, TKey> where TModel : class
{
    [UsePaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public virtual IQueryable<TModel> GetUsingPaging([Service] IGenericGraphQLRepository<TModel, TKey> repository)
    {
        return repository.Queryable();
    }

    [UseOffsetPaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public virtual IQueryable<TModel> GetUsingOffsetPaging([Service] IGenericGraphQLRepository<TModel, TKey> repository)
    {
        return repository.Queryable();
    }
}