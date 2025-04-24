using TalentDataAccess.DataAccess;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentLogic.GraphQL.Repositories
{
    // ReSharper disable once InconsistentNaming
    public class TalentCVGraphQLRepository : GenericGraphQLRepository<Talent, int>
    {
        public TalentCVGraphQLRepository(TalentDbContext context) : base(context)
        {
        }
    }
}
