using System.Threading.Tasks;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.Crud.ReadOnly
{
    public interface IDashboardRead
    {
        Task<BoDashBoardInfo> GetDashBoardInfo();
    }


}
