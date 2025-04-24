using HotChocolate;
using HotChocolate.Types;
using System.Linq;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.GraphQL.Repositories;

namespace TalentLogic.GraphQL.Resolvers
{
    [ExtendObjectType("Query")]
    // ReSharper disable once InconsistentNaming
    public class TalentCVResolver: BaseResolver<Talent, int>
    {
        [GraphQLName("TalentCVs")]
        public override IQueryable<Talent> GetUsingPaging(IGenericGraphQLRepository<Talent, int> repository)
        {
            return base.GetUsingPaging(repository);
        }

        [GraphQLName("TalentCVsOffsetPaging")]
        public override IQueryable<Talent> GetUsingOffsetPaging(IGenericGraphQLRepository<Talent, int> repository)
        {
            return base.GetUsingOffsetPaging(repository);
        }
    }

    // ReSharper disable once InconsistentNaming
    public class TalentCVType : ObjectType<Talent>
    {
        protected override void Configure(IObjectTypeDescriptor<Talent> descriptor)
        {
            descriptor.Field(f => f.Description).UseFiltering();
        }
    }
}
