using System.Threading.Tasks;
using TalentDataAccess.DataAccess.Repositories;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.Crud.ReadOnly
{
    public class DashBoardInfoRead : IDashboardRead
    {
        private readonly ITalentRefactoredRepository _talentRefactoredRepository;
        private readonly ITalentPropertyLabelRepository _talentPropertyLabelRepository;
        private readonly IOrganizationRepository _organizationRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IVacancyCompleteRepository _vacancyCompleteRepository;

        public DashBoardInfoRead(
            ITalentRefactoredRepository talentCVRepository,
            ITalentPropertyLabelRepository talentPropertyLabelRepository,
            IOrganizationRepository organizationRepository,
            ICompanyRepository companyRepository,
            IVacancyCompleteRepository vacancyCompleteRepository
        )
        {
            _talentRefactoredRepository = talentCVRepository;
            _talentPropertyLabelRepository = talentPropertyLabelRepository;
            _organizationRepository = organizationRepository;
            _companyRepository = companyRepository;
            _vacancyCompleteRepository = vacancyCompleteRepository;
        }

        public async Task<BoDashBoardInfo> GetDashBoardInfo()
        {
            var boDashBoardInfo = new BoDashBoardInfo
            {
                TotalParentLabels = await _talentPropertyLabelRepository.CountLabels(true),
                TotalChildLabels = await _talentPropertyLabelRepository.CountLabels(false),
                TotalTalents = await _talentRefactoredRepository.CountRecords(),
                TotalOrganizations = await _organizationRepository.CountOrganizations(),
                TotalCompanies = await _companyRepository.CountCompanies(),
                TotalVacancies = await _vacancyCompleteRepository.CountVacancies()
            };

            return boDashBoardInfo;
        }

    }

}