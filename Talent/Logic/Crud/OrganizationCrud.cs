using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.Repositories;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.Crud.ReadOnly;
using TalentLogic.Logic.ObjectMappers;

namespace TalentLogic.Logic.Crud
{
    public class OrganizationCrud : IOrganizationCrud
    {
        private readonly IOrganizationRepository _organizationRepository;

        public OrganizationCrud(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }

        public async Task CreateOrganization(BOOrganization bo)
        {
            await _organizationRepository.Create(OrganizationMapper.Map(bo));
        }

        public async Task DeleteOrganization(int id)
        {
            await _organizationRepository.Delete(id);
        }

        public async Task<List<BOOrganization>> GetAllOrganizations()
        {
            var items = await _organizationRepository.GetAll();

            List<BOOrganization> list = new List<BOOrganization>();

            foreach(var item in items)
            {
                list.Add(OrganizationMapper.Map(item));
            }

            return list;
        }

        public async Task<BOOrganization> GetOrganizationById(int id)
        {
            var item = await _organizationRepository.GetById(id);
            return OrganizationMapper.Map(item);
        }

        public async Task<BOOrganizationStyle> GetOrganizationStyle(int organization = 0)
        {
            BOOrganizationStyle bo = new BOOrganizationStyle();

            if(organization == 0)
            {
                bo.StyleSheet = "default";
            }
            else
            {
                var item = await _organizationRepository.GetById(organization);
                bo.StyleSheet = OrganizationMapper.GetStyleName(item.Theme);
            }

            return bo;
        }

        public async Task UpdateOrganization(BOOrganization bo)
        {
            if(bo.Id == null)
            {
                throw new Exception("Id can't be null");
            }

            int targetId = bo.Id ?? 0;

            if(targetId == 0)
            {
                throw new Exception("Id can't be null");
            }

            await _organizationRepository.Update(targetId, OrganizationMapper.Map(bo));
        }
    }
}
