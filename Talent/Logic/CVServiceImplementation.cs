using CrossCuttingConcerns.PagingSorting;
using System.Collections.Generic;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.Repositories;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.Crud;
using TalentLogic.Logic.Crud.ReadOnly;

namespace TalentLogic.Logic
{
    public class CVServiceImplementation : ICVService
    {        
        private readonly IDashboardRead _dashboardRead;
        private readonly ITalentRefactoredCrud _talentRefactoredCrud;
        //private readonly ITalentCVCrud _talentCVCrud;
        //private readonly IDriverLicenseCrud _driverLicenseCrud;
        //private readonly IEducationCrud _educationCrud;
        //private readonly IJobsectorCrud _jobSectorCrud;
        //private readonly IJobAgreementTypeCrud _jobAgreementTypeCrud;

        public CVServiceImplementation(             
             IDashboardRead dashboardRead,
             ITalentRefactoredCrud talentRefactoredCrud
             //ITalentCVCrud talentCVCrud,
             //IDriverLicenseCrud driverLicenseCrud,
             //IEducationCrud educationCrud,
             //IJobsectorCrud jobSectorCrud,
             //IJobAgreementTypeCrud jobAgreementTypeCrud
             )
        {
            _dashboardRead = dashboardRead;
            _talentRefactoredCrud = talentRefactoredCrud;
            //_talentCVCrud = talentCVCrud;
            //_driverLicenseCrud = driverLicenseCrud;
            //_educationCrud = educationCrud;
            //_jobSectorCrud = jobSectorCrud;
            //_jobAgreementTypeCrud = jobAgreementTypeCrud;
        }

        public async Task CreateTalent(BOTalentRefactored bo)
        {
            await _talentRefactoredCrud.CreateTalent(bo);
        }

        public async Task DeleteTalent(int id)
        {
            await _talentRefactoredCrud.DeleteTalent(id);
        }

        public async Task<List<BOTalentRefactored>> GetAll()
        {
            return await _talentRefactoredCrud.GetAll();
        }

        public async Task<List<BOTalentRefactored>> GetAllFavourites(int[] favourites, int organization = 0)
        {
            return await _talentRefactoredCrud.GetAllFavourites(favourites, organization);
        }

        public async Task<BOTalentRefactored> GetById(int id)
        {
            return await _talentRefactoredCrud.GetById(id);
        }

        public async Task<BOTalentRefactored> GetByIdAndOrganization(int id, int organization = 0)
        {
            return await _talentRefactoredCrud.GetByIdAndOrganization(id, organization);
        }

        public async Task<BoDashBoardInfo> GetDashBoardInfo()
        {
            return await _dashboardRead.GetDashBoardInfo().ConfigureAwait(false);
        }

        public async Task<PaginatedList<BOTalentRefactored>> GetFilteredList(int? pageNumber, string sortField, string sortOrder, int? pageSize, BOActiveSearchFilter filters, int organization = 0)
        {
            return await _talentRefactoredCrud.GetFilteredList(pageNumber, sortField, sortOrder, pageSize, filters, organization);
        }

        public async Task<PaginatedList<BOTalentRefactored>> GetPagedList(int? pageNumber, string sortField, string sortOrder, int? pageSize)
        {
            return await _talentRefactoredCrud.GetPagedList(pageNumber, sortField, sortOrder, pageSize);
        }

        public Task<PaginatedList<BOTalentRefactored>> GetPagedList(int? pageNumber, string sortField, string sortOrder, int? pageSize, int organization = 0)
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateTalent(BOTalentRefactored bo)
        {
            await _talentRefactoredCrud.UpdateTalent(bo);
        }



        //public async Task<List<BOTalentCV>> GetAllTalentCVs()
        //{
        //    return await _talentCVCrud.GetAllTalentCVs().ConfigureAwait(false);
        //}

        //public async Task<BOTalentCV> GetById(int id)
        //{
        //    return await _talentCVCrud.GetById(id).ConfigureAwait(false);
        //}

        //public async Task Create(BOTalentCV data)
        //{
        //    await _talentCVCrud.Create(data).ConfigureAwait(false);
        //}

        //public async Task Delete(int id)
        //{
        //    await _talentCVCrud.Delete(id).ConfigureAwait(false);
        //}

        //public async Task Update(BOTalentCV data)
        //{
        //    await _talentCVCrud.Update(data).ConfigureAwait(false);
        //}

        //public async Task DeleteDriverLicense(int id)
        //{
        //    await _driverLicenseCrud.DeleteDriverLicense(id).ConfigureAwait(false);
        //}

        //public async Task UpdateDriverLicense(int id, BODriverLicense driverLicense)
        //{
        //    await _driverLicenseCrud.UpdateDriverLicense(id, driverLicense).ConfigureAwait(false);
        //}

        //public async Task AddDriverLicense(BODriverLicense driverLicense)
        //{
        //    await _driverLicenseCrud.AddDriverLicense(driverLicense).ConfigureAwait(false);
        //}

        //public async Task<List<BODriverLicense>> GetAllDriverLicenses()
        //{
        //    return await _driverLicenseCrud.GetAllDriverLicenses().ConfigureAwait(false);
        //}

        //public async Task<BODriverLicense> GetDriverLicenseById(int id)
        //{
        //    return await _driverLicenseCrud.GetDriverLicenseById(id).ConfigureAwait(false);
        //}

        //public async Task<List<BOEducation>> GetAllEducations()
        //{
        //    return await _educationCrud.GetAllEducations().ConfigureAwait(false);
        //}

        //public async Task<BOEducation> GetEducationById(int id)
        //{
        //    return await _educationCrud.GetEducationById(id).ConfigureAwait(false);
        //}

        //public async Task DeleteEducation(int id)
        //{
        //    await _educationCrud.DeleteEducation(id).ConfigureAwait(false);
        //}

        //public async Task UpdateEducation(int id, BOEducation boEducation)
        //{
        //    await _educationCrud.UpdateEducation(id, boEducation).ConfigureAwait(false);
        //}

        //public async Task AddEducation(BOEducation boEducation)
        //{
        //    await _educationCrud.AddEducation(boEducation).ConfigureAwait(false);
        //}

        //public async Task<List<BOJobSector>> GetAllJobSectors()
        //{
        //    return await _jobSectorCrud.GetAllJobSectors().ConfigureAwait(false);
        //}

        //public async Task<BOJobSector> GetJobSectorById(int id)
        //{
        //    return await _jobSectorCrud.GetJobSectorById(id).ConfigureAwait(false);
        //}

        //public async Task DeleteJobSector(int id)
        //{
        //    await _jobSectorCrud.DeleteJobSector(id).ConfigureAwait(false);
        //}

        //public async Task UpdateJobSector(int id, BOJobSector boJobSector)
        //{
        //    await _jobSectorCrud.UpdateJobSector(id, boJobSector);
        //}

        //public async Task AddJobSector(BOJobSector boJobSector)
        //{
        //    await _jobSectorCrud.AddJobSector(boJobSector);
        //}

        //public async Task<List<BOJobAgreementType>> GetAllJobAgreementTypes()
        //{
        //    return await _jobAgreementTypeCrud.GetAllJobAgreementTypes().ConfigureAwait(false);
        //}

        //public async Task<BOJobAgreementType> GetJobAgreementTypeById(int id)
        //{
        //    return await _jobAgreementTypeCrud.GetJobAgreementTypeById(id).ConfigureAwait(false);
        //}

        //public async Task DeleteJobAgreementType(int id)
        //{
        //    await _jobAgreementTypeCrud.DeleteJobAgreementType(id).ConfigureAwait(false);
        //}

        //public async Task UpdateJobAgreementType(int id, BOJobAgreementType boJobAgreementType)
        //{
        //    await _jobAgreementTypeCrud.UpdateJobAgreementType(id, boJobAgreementType).ConfigureAwait(false);
        //}

        //public async Task AddJobAgreementType(BOJobAgreementType boJobAgreementType)
        //{
        //    await _jobAgreementTypeCrud.AddJobAgreementType(boJobAgreementType).ConfigureAwait(false);
        //}

    }
}
