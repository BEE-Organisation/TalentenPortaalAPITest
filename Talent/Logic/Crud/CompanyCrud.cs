using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.Repositories;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.ObjectMappers;

namespace TalentLogic.Logic.Crud
{
    public class CompanyCrud : ICompanyCrud
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IVacancyCompleteRepository _vacancyCompleteRepository;

        public CompanyCrud(ICompanyRepository companyRepository, IVacancyCompleteRepository vacancyCompleteRepository)
        {
            _companyRepository = companyRepository;
            _vacancyCompleteRepository = 
            _vacancyCompleteRepository = vacancyCompleteRepository;
        }

        public async Task CreateCompany(BOCompany bo)
        {
            await _companyRepository.Create(CompanyMapper.Map(bo));
        }

        public async Task<BOCompanyDelete> DeleteCompany(int id)
        {
            BOCompanyDelete status = new BOCompanyDelete();

            try
            {
                int count = await _vacancyCompleteRepository.CountCompanyIdInUse(id);

                if(count == 0)
                {
                    await _companyRepository.Delete(id);
                    status.IsDeleted = true;
                    status.Message = "Bedrijf succesvol verwijderd.";
                }
                else
                {
                    status.IsDeleted = false;
                    status.Message = "Kan bedrijf niet verwijderen, want is in gebruik door Vacature(s).";
                }                
            }
            catch
            {
                status.IsDeleted = false;
                status.Message = "Fout: Kan bedrijf niet verwijderen.";
            }           

            return status;
        }

        public async Task<List<BOCompany>> GetAllCompanies()
        {
            var items = await _companyRepository.GetAll();

            List<BOCompany> list = new List<BOCompany>();

            foreach (var item in items)
            {
                list.Add(CompanyMapper.Map(item, true));
            }

            return list;
        }

        public async Task<List<BOCompany>> GetAllCompaniesById(string keycloakId)
        {
            var items = await _companyRepository.GetAllById(keycloakId);

            List<BOCompany> list = new List<BOCompany>();

            foreach (var item in items)
            {
                list.Add(CompanyMapper.Map(item, true));
            }

            return list;
        }

        public async Task<BOCompany> GetCompanyById(int id)
        {
            var item = await _companyRepository.GetById(id);
            return CompanyMapper.Map(item, true);
        }

        public async Task UpdateCompany(BOCompany bo)
        {
            await _companyRepository.Update(CompanyMapper.Map(bo));
        }
    }
}
