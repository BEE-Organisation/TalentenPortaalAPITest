using HotChocolate.Execution.Configuration;
using TalentLogic.GraphQL.Mutations;
using TalentLogic.GraphQL.Resolvers;

namespace TalentBackend.Extensions;

public static class RequestExecutorBuilderExtensions
{
    public static IRequestExecutorBuilder AddResolvers(this IRequestExecutorBuilder requestExecutionBuilder)
    {
        return requestExecutionBuilder
                .AddType<TalentCVResolver>()
                .AddType<TalentCVType>();
    }

    public static IRequestExecutorBuilder AddMutations(this IRequestExecutorBuilder requestExecutionBuilder)
    {
        return requestExecutionBuilder
                .AddType<TalentCVMutation>();
    }
}