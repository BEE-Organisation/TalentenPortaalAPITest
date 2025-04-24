using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.GraphQL.Repositories;

namespace TalentBackend.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        return services
                .AddTransient<IGenericGraphQLRepository<Talent, int>, TalentCVGraphQLRepository>();
    }

}