using TalentLogic.Logic.Crud;
using TalentLogic.Logic.Crud.ReadOnly;

namespace TalentLogic.Logic
{
    //public interface ICVService : IDashboardRead, ITalentCVCrud, IDriverLicenseCrud, IEducationCrud, IJobsectorCrud, IJobAgreementTypeCrud
    public interface ICVService : IDashboardRead, ITalentRefactoredCrud
    {

    }
}
