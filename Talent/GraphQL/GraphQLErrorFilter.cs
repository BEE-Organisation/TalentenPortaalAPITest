using HotChocolate;

namespace TalentLogic.GraphQL;

// ReSharper disable once InconsistentNaming
public class GraphQLErrorFilter : IErrorFilter
{
    public IError OnError(IError error)
    {
        var exception = error.Exception;

        if (exception == null) return error.WithMessage(error.Message);

        if (error.Exception?.InnerException != null) return error.WithMessage(error.Exception.InnerException.Message);

        return error.WithMessage(error.Exception?.Message ?? string.Empty);
    }
}