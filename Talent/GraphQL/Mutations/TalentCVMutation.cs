using HotChocolate;
using HotChocolate.Types;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.GraphQL.Repositories;

namespace TalentLogic.GraphQL.Mutations
{
    [ExtendObjectType("Mutation")]
    // ReSharper disable once InconsistentNaming
    public class TalentCVMutation : BaseMutation<Talent, int>
    {
        [GraphQLName("TalentCVInsert")]
        public override Task<Talent> Insert(Talent entity, [Service] IGenericGraphQLRepository<Talent, int> repository)
        {
            return base.Insert(entity, repository);
        }

        [GraphQLName("TalentCVUpdate")]
        public override Task<Talent> Update(Talent entity, int id,
            [Service] IGenericGraphQLRepository<Talent, int> repository)
        {
            return base.Update(entity, entity.Id, repository);
        }

        [GraphQLName("TalentCVDelete")]
        public override Task<bool> Delete(int id, [Service] IGenericGraphQLRepository<Talent, int> repository)
        {
            return base.Delete(id, repository);
        }
    }
}
