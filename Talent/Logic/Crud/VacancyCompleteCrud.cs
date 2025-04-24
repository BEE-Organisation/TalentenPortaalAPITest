using CrossCuttingConcerns.PagingSorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentDataAccess.DataAccess.Repositories;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.ObjectMappers;

namespace TalentLogic.Logic.Crud
{
    public class VacancyCompleteCrud : IVacancyCompleteCrud
    {
        private readonly IVacancyCompleteRepository _vacancyCompleteRepository;
        private readonly ITalentPropertyLabelRepository _talentPropertyLabelRepository;
        private readonly IVacancyOfferRepository _vacancyOfferRepository;
        private readonly IVacancyDemandRepository _vacancyDemandRepository;
        private readonly IVacancyDemandDetailRepository _vacancyDemandDetailRepository;
        private readonly IVacancyTextRepository _vacancyTextRepository;

        public VacancyCompleteCrud(
            IVacancyCompleteRepository vacancyCompleteRepository, 
            ITalentPropertyLabelRepository talentPropertyLabelRepository,
            IVacancyOfferRepository vacancyOfferRepository,
            IVacancyDemandRepository vacancyDemandRepository,
            IVacancyDemandDetailRepository vacancyDemandDetailRepository,
            IVacancyTextRepository vacancyTextRepository
        )
        {
            _vacancyCompleteRepository = vacancyCompleteRepository;
            _talentPropertyLabelRepository = talentPropertyLabelRepository;
            _vacancyOfferRepository = vacancyOfferRepository;
            _vacancyDemandRepository = vacancyDemandRepository;
            _vacancyDemandDetailRepository = vacancyDemandDetailRepository;
            _vacancyTextRepository = vacancyTextRepository;
        }

        public async Task CreateVacancyComplete(BOVacancyComplete bo)
        {
            try
            {
                await _vacancyCompleteRepository.Create(VacancyCompleteMapper.Map(bo));
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }            
        }

        public async Task DeleteVacancyComplete(int id)
        {
            try
            {
                var record = await _vacancyCompleteRepository.GetById(id);

                if (record != null)
                {
                    await _vacancyCompleteRepository.Delete(record.Id);
                    await _vacancyOfferRepository.Delete(record.VacancyOfferId ?? 0);
                    await _vacancyDemandRepository.Delete(record.VacancyDemandId ?? 0);
                    await _vacancyDemandDetailRepository.Delete(record.VacancyDemandDetailId ?? 0);
                    await _vacancyTextRepository.Delete(record.VacancyTextId ?? 0);
                }
            }
            catch(Exception ex) {
                throw new Exception("Something went wrong: " + ex.Message);
            }            
        }

        public async Task<List<BOVacancyComplete>> GetAllVacancies()
        {
            var records = await _vacancyCompleteRepository.GetAll();

            List<BOVacancyComplete> list = new List<BOVacancyComplete>();

            List<int> allLabelIds = new List<int>();

            foreach (var record in records)
            {
                int[] secondaryConditionIds = record.VacancyOffer.SecondaryConditions;
                allLabelIds = AddUniqueIds(allLabelIds, secondaryConditionIds);
            }

            var allLables = await _talentPropertyLabelRepository.GetByIds(allLabelIds);

            foreach (var record in records)
            {
                list.Add(VacancyCompleteMapper.Map(record, allLables));
            }

            return list;
        }

        public async Task<List<BOVacancyComplete>> GetAllVacanciesByCompany(int[] organizationIds)
        {
            List<int> ids = new List<int>();
            ids.AddRange(organizationIds);

            var records = await _vacancyCompleteRepository.GetAllByOrganization(ids);

            List<BOVacancyComplete> list = new List<BOVacancyComplete>();

            List<int> allLabelIds = new List<int>();

            foreach (var record in records)
            {
                int[] secondaryConditionIds = record.VacancyOffer.SecondaryConditions;
                allLabelIds = AddUniqueIds(allLabelIds, secondaryConditionIds);

                int[] parentIDs = record.VacancyDemandDetail.ParentProperties;
                allLabelIds = AddUniqueIds(allLabelIds, parentIDs);

                int[] childIds = record.VacancyDemandDetail.ChildProperties;
                allLabelIds = AddUniqueIds(allLabelIds, childIds);
            }

            var allLabels = await _talentPropertyLabelRepository.GetByIds(allLabelIds);

            foreach (var record in records)
            {
                list.Add(VacancyCompleteMapper.Map(record, allLabels));
            }

            return list;
        }

        public async Task<PaginatedList<BOVacancyComplete>> GetFilteredList(int? pageNumber, string sortField, string sortOrder, int? pageSize, BOActiveSearchFilter filters)
        {
            try
            {
                PaginatedList<VacancyComplete> result = await _vacancyCompleteRepository.GetFilteredList(ActiveSearchFilterMapper.Map(filters), pageNumber, sortField, sortOrder, pageSize);

                List<int> allLabelIds = new List<int>();

                result.Items.ForEach((item) => {
                    int[] secondaryConditionIds = item.VacancyOffer.SecondaryConditions;
                    allLabelIds = AddUniqueIds(allLabelIds, secondaryConditionIds);

                    int[] parentIDs = item.VacancyDemandDetail.ParentProperties;
                    allLabelIds = AddUniqueIds(allLabelIds, parentIDs);

                    int[] childIds = item.VacancyDemandDetail.ChildProperties;
                    allLabelIds = AddUniqueIds(allLabelIds, childIds);
                });

                var allLabels = await _talentPropertyLabelRepository.GetByIds(allLabelIds);

                var allLables = await _talentPropertyLabelRepository.GetByIds(allLabelIds);

                return new PaginatedList<BOVacancyComplete>
                {
                    CurrentPage = result.CurrentPage,
                    From = result.From,
                    PageSize = result.PageSize,
                    To = result.To,
                    TotalCount = result.TotalCount,
                    TotalPages = result.TotalPages,
                    ItemIndexes = result.ItemIndexes,
                    Items = result.Items.Select((item) => VacancyCompleteMapper.Map(item, allLables)).ToList(),
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<PaginatedList<BOVacancyComplete>> GetList(int? pageNumber, string sortField, string sortOrder, int? pageSize)
        {
            PaginatedList<VacancyComplete> result = await _vacancyCompleteRepository.GetList(pageNumber, sortField, sortOrder, pageSize);

            List<int> allLabelIds = new List<int>();

            result.Items.ForEach((item) => {
                int[] secondaryConditionIds = item.VacancyOffer.SecondaryConditions;
                allLabelIds = AddUniqueIds(allLabelIds, secondaryConditionIds);

                int[] parentIDs = item.VacancyDemandDetail.ParentProperties;
                allLabelIds = AddUniqueIds(allLabelIds, parentIDs);

                int[] childIds = item.VacancyDemandDetail.ChildProperties;
                allLabelIds = AddUniqueIds(allLabelIds, childIds);
            });

            var allLabels = await _talentPropertyLabelRepository.GetByIds(allLabelIds);

            var allLables = await _talentPropertyLabelRepository.GetByIds(allLabelIds);

            return new PaginatedList<BOVacancyComplete>
            {
                CurrentPage = result.CurrentPage,
                From = result.From,
                PageSize = result.PageSize,
                To = result.To,
                TotalCount = result.TotalCount,
                TotalPages = result.TotalPages,
                ItemIndexes = result.ItemIndexes,
                Items = result.Items.Select((item) => VacancyCompleteMapper.Map(item, allLables)).ToList(),
            };
        }

        public async Task<BOVacancyComplete> GetVacancyCompleteById(int id)
        {
            var record = await _vacancyCompleteRepository.GetById(id);

            List<int> allLabelIds = new List<int>();

            int[] secondaryConditionIds = record.VacancyOffer.SecondaryConditions;

            if(secondaryConditionIds.Length > 0)
            {
                allLabelIds = AddUniqueIds(allLabelIds, secondaryConditionIds);
            }

            if(record.VacancyDemandDetail != null)
            {
                int[] parentIds = record.VacancyDemandDetail.ParentProperties;
                int[] childIds = record.VacancyDemandDetail.ChildProperties;

                if(parentIds.Length > 0)
                {
                    allLabelIds = AddUniqueIds(allLabelIds, parentIds);
                }

                if(childIds.Length > 0)
                {
                    allLabelIds = AddUniqueIds(allLabelIds, childIds);
                }
            }

            var allLabels = await _talentPropertyLabelRepository.GetByIds(allLabelIds);
            return VacancyCompleteMapper.Map(record, allLabels);
        }

        public async Task UpdateVacancyComplete(BOVacancyComplete bo)
        {
            var record = VacancyCompleteMapper.Map(bo);
            await _vacancyCompleteRepository.Update(record.Id, record);
        }

        private List<int> AddUniqueIds(List<int> list, int[] ids)
        {
            foreach (var id in ids)
            {
                if (!list.Contains(id))
                {
                    list.Add(id);
                }
            }

            return list;
        }

    }
}
