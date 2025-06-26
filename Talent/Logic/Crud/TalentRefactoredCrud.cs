using CrossCuttingConcerns.PagingSorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentDataAccess.DataAccess.Repositories;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.ObjectMappers;

namespace TalentLogic.Logic.Crud
{
    public class TalentRefactoredCrud : ITalentRefactoredCrud
    {
        private readonly ITalentRefactoredRepository _talentRefactoredRepository;
        private readonly IPastExperienceRepository _pastExperienceRepository;
        private readonly ITalentPropertyRepository _talentPropertyRepository;
        private readonly IHobbyRepository _hobbyRepository;
        private readonly IEducationDetailRepository _educationDetailRepository;

        public TalentRefactoredCrud(
            ITalentRefactoredRepository talentRefactoredRepository,
            IPastExperienceRepository pastExperienceRepository,
            ITalentPropertyRepository talentPropertyRepository,
            IHobbyRepository hobbyRepository,
            IEducationDetailRepository educationDetailRepository
        )
        {
            _talentRefactoredRepository = talentRefactoredRepository;
            _pastExperienceRepository = pastExperienceRepository;
            _talentPropertyRepository = talentPropertyRepository;
            _hobbyRepository = hobbyRepository;
            _educationDetailRepository = educationDetailRepository;
        }

        public async Task<List<BOTalentRefactored>> GetAll()
        {
            List<BOTalentRefactored> businessObjects = new List<BOTalentRefactored>();

            var records = await _talentRefactoredRepository.GetAll();

            foreach (var record in records)
            {
                BOTalentRefactored bo = TalentRefactoredMapper.Map(record);

                //var pastExperience = await _pastExperienceRepository.GetAllById(record.Id);

                List<BOTalentPropertyMainCategory> data = new List<BOTalentPropertyMainCategory>();

                if (record.TalentPropertyMainCategoryLinks.Count() > 0)
                {
                    List<int> labelIds = GetLabelIds(record.TalentPropertyMainCategoryLinks);
                    var labels = await _talentPropertyRepository.GetLabelsByIds(labelIds);

                    foreach (var mainCategory in record.TalentPropertyMainCategoryLinks)
                    {
                        data.Add(TalentPropertyMapper.Map(mainCategory, labels));
                    }
                }

                bo.TalentProperties = data;

                //Neccessary for all page?
                //bo.PastExperience = PastExperienceMapper.Map(pastExperience);

                businessObjects.Add(bo);
            }

            return businessObjects;
        }

        public async Task<BOTalentRefactored> GetById(int id)
        {
            try
            {
                var record = await _talentRefactoredRepository.GetById(id);

                if(record != null)
                {
                    var pastExperience = await _pastExperienceRepository.GetAllById(id);
                    var hobbies = await _hobbyRepository.GetAllById(id);
                    var eductionDetails = await _educationDetailRepository.GetAllById(id);

                    BOTalentRefactored bo = TalentRefactoredMapper.Map(record);

                    List<BOTalentPropertyMainCategory> data = new List<BOTalentPropertyMainCategory>();

                    if (record.TalentPropertyMainCategoryLinks.Count() > 0)
                    {
                        List<int> labelIds = GetLabelIds(record.TalentPropertyMainCategoryLinks);
                        var labels = await _talentPropertyRepository.GetLabelsByIds(labelIds);

                        foreach (var mainCategory in record.TalentPropertyMainCategoryLinks)
                        {
                            data.Add(TalentPropertyMapper.Map(mainCategory, labels));
                        }
                    }

                    bo.TalentProperties = data;

                    bo.PastExperience = PastExperienceMapper.Map(pastExperience);

                    bo.Hobbies = HobbyMapper.Map(hobbies);

                    bo.EducationDetails = EducationDetailsMapper.Map(eductionDetails);

                    return bo;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public async Task<PaginatedList<BOTalentRefactored>> GetPagedList(
            int? pageNumber,
            string sortField,
            string sortOrder,
            int? pageSize,
            int organization = 0
        )
        {
            PaginatedList<Talent> result = await _talentRefactoredRepository.GetList(pageNumber, sortField, sortOrder, pageSize, organization);

            var allLabels = await _talentPropertyRepository.GetAllLabels();

            return new PaginatedList<BOTalentRefactored>
            {
                CurrentPage = result.CurrentPage,
                From = result.From,
                PageSize = result.PageSize,
                To = result.To,
                TotalCount = result.TotalCount,
                TotalPages = result.TotalPages,
                ItemIndexes = result.ItemIndexes,
                Items = result.Items.Select((item) => new BOTalentRefactored() {
                    Id = item.Id,
                    Name = item.Name,
                    Organization = (item.Organization != null) ? OrganizationMapper.Map(item.Organization) : null,
                    LaborMarketRegion = (item.LaborMarketRegion != null) ? LaborMarketRegionMapper.Map(item.LaborMarketRegion) : null,
                    JobTitle = item.JobTitle,
                    Description = item.Description,
                    Education = item.Education,
                    Municipality = item.Municipality,
                    ProfilePhotoRef = item.ProfilePhotoRef,
                    PitchUrl = (!item.PitchUrl.Equals("") && !item.PitchUrl.Equals("null")) ? item.PitchUrl : null,
                    LoopUrl = (!item.LoopUrl.Equals("")) ? item.LoopUrl : null,
                    TravelDistance = item.TravelDistance,
                    AvailableHours = item.AvailableHours,
                    TalentProperties = GetMainAndSubCategories(item.TalentPropertyMainCategoryLinks, allLabels),                    

                }).ToList()
            };
        }

        private List<BOTalentPropertyMainCategory> GetMainAndSubCategories(ICollection<TalentPropertyMainCategoryLink> items, List<TalentPropertyLabel> allLabels)
        {
            List<BOTalentPropertyMainCategory> list = new List<BOTalentPropertyMainCategory>();

            if (items.Count() > 0)
            {
                foreach (var item in items)
                {
                    list.Add(TalentPropertyMapper.Map(item, allLabels));
                }
            }

            return list;
        }


        //Duplicate method. ???
        private List<int> GetLabelIds(ICollection<TalentPropertyMainCategoryLink> items)
        {
            List<int> list = new List<int>();

            foreach (var item in items)
            {
                if (!list.Contains(item.TalentPropertyLabelId))
                {
                    list.Add(item.TalentPropertyLabelId);
                }

                if (item.TalentPropertySubCategoryLinks.Count() > 0)
                {
                    foreach (var subItems in item.TalentPropertySubCategoryLinks)
                    {
                        if (!list.Contains(subItems.TalentPropertyLabelId))
                        {
                            list.Add(subItems.TalentPropertyLabelId);
                        }
                    }
                }
            }

            return list;
        }

        public async Task CreateTalent(BOTalentRefactored bo)
        {
            try
            {
                int id = await _talentRefactoredRepository.CreateNew(TalentRefactoredMapper.Map(bo));

                if(bo.TalentProperties.Count() > 0)
                {
                    List<TalentPropertyMainCategoryLink> mainProperties = new List<TalentPropertyMainCategoryLink>();

                    foreach(var mainProperty in bo.TalentProperties)
                    {
                        mainProperty.TalentId = id;
                        mainProperties.Add(TalentPropertyMapper.Map(mainProperty));
                    }

                    await _talentPropertyRepository.CreateRange(mainProperties);
                }

                if(bo.PastExperience.Count() > 0)
                {
                    foreach (var pastExperience in bo.PastExperience)
                    {
                        pastExperience.TalentId = id;
                    }

                    await _pastExperienceRepository.Create(PastExperienceMapper.Map(bo.PastExperience));
                }

                if(bo.EducationDetails.Count() > 0)
                {
                    await _educationDetailRepository.Create(EducationDetailsMapper.Map(bo.EducationDetails, id));
                }

                if (bo.Hobbies.Count() > 0)
                {
                    foreach(var hobby in bo.Hobbies)
                    {
                        hobby.TalentId = id;
                    }

                    await _hobbyRepository.Create(HobbyMapper.Map(bo.Hobbies));
                }
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }            
        }

        public async Task UpdateTalent(BOTalentRefactored bo)
        {
            try
            {                
                if(bo.Id == null)
                {
                    throw new Exception("Id can't be null");
                }

                int targetId = bo.Id ?? 0;

                if (targetId == 0)
                {
                    throw new Exception("Id can't be null");
                }

                var update = TalentRefactoredMapper.Map(bo);
                await _talentRefactoredRepository.Update(targetId, update);

                //Remove previous properties.
                var allProperties = await _talentPropertyRepository.GetAllByTalentId(targetId);

                List<int> mainIds = new List<int>();
                List<int> subIds = new List<int>();

                foreach (var mainProperty in allProperties)
                {
                    mainIds.Add(mainProperty.Id);

                    if (mainProperty.TalentPropertySubCategoryLinks.Count() > 0)
                    {
                        foreach (var subProperty in mainProperty.TalentPropertySubCategoryLinks)
                        {
                            subIds.Add(subProperty.Id);
                        }
                    }
                }

                if(mainIds.Count() > 0)
                {
                    await _talentPropertyRepository.RemoveMainCategoryByIds(mainIds);
                }
                
                if(subIds.Count() > 0)
                {
                    await _talentPropertyRepository.RemoveSubCategoryByIds(subIds);
                }                

                if (bo.TalentProperties.Count() > 0)
                {
                   //Add new.
                    List<TalentPropertyMainCategoryLink> mainProperties = new List<TalentPropertyMainCategoryLink>();

                    foreach (var mainProperty in bo.TalentProperties)
                    {
                        mainProperty.TalentId = targetId;
                        mainProperties.Add(TalentPropertyMapper.Map(mainProperty));
                    }

                    await _talentPropertyRepository.CreateRange(mainProperties);
                }

                //Remove previous PastExperience + Update:
                if(bo.PastExperience.Count() > 0)
                {
                    await _pastExperienceRepository.Update(targetId, PastExperienceMapper.Map(bo.PastExperience));
                }
                else
                {
                    await _pastExperienceRepository.Delete(targetId);
                }

                //Remove previous EducationDetails + Update:
                if (bo.EducationDetails.Count() > 0)
                {
                    await _educationDetailRepository.Update(targetId, EducationDetailsMapper.Map(bo.EducationDetails, targetId));
                }
                else
                {
                    await _educationDetailRepository.Delete(targetId);
                }

                //Remove previous Hobbies + Update.
                if (bo.Hobbies.Count() > 0)
                {
                    await _hobbyRepository.Update(targetId, HobbyMapper.Map(bo.Hobbies));
                }
                else
                {
                    await _hobbyRepository.Delete(targetId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteTalent(int id)
        {
            try
            {
                await _talentRefactoredRepository.Delete(id);

                //Remove previous properties.
                var allProperties = await _talentPropertyRepository.GetAllByTalentId(id);

                List<int> mainIds = new List<int>();
                List<int> subIds = new List<int>();

                foreach (var mainProperty in allProperties)
                {
                    mainIds.Add(mainProperty.Id);

                    if (mainProperty.TalentPropertySubCategoryLinks.Count() > 0)
                    {
                        foreach (var subProperty in mainProperty.TalentPropertySubCategoryLinks)
                        {
                            subIds.Add(subProperty.Id);
                        }
                    }
                }

                if (mainIds.Count() > 0)
                {
                    await _talentPropertyRepository.RemoveMainCategoryByIds(mainIds);
                }

                if (subIds.Count() > 0)
                {
                    await _talentPropertyRepository.RemoveSubCategoryByIds(subIds);
                }

                await _pastExperienceRepository.Delete(id);
                await _educationDetailRepository.Delete(id);
                await _hobbyRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<BOTalentRefactored> GetByIdAndOrganization(int id, int organization = 0)
        {
            try
            {
                var record = await _talentRefactoredRepository.GetByIdAndOrganization(id, organization);

                if (record != null)
                {
                    var pastExperience = await _pastExperienceRepository.GetAllById(id);
                    var hobbies = await _hobbyRepository.GetAllById(id);
                    var eductionDetails = await _educationDetailRepository.GetAllById(id);

                    BOTalentRefactored bo = TalentRefactoredMapper.Map(record);

                    List<BOTalentPropertyMainCategory> data = new List<BOTalentPropertyMainCategory>();

                    if (record.TalentPropertyMainCategoryLinks.Count() > 0)
                    {
                        List<int> labelIds = GetLabelIds(record.TalentPropertyMainCategoryLinks);
                        var labels = await _talentPropertyRepository.GetLabelsByIds(labelIds);

                        foreach (var mainCategory in record.TalentPropertyMainCategoryLinks)
                        {
                            data.Add(TalentPropertyMapper.Map(mainCategory, labels));
                        }
                    }

                    bo.TalentProperties = data;

                    bo.PastExperience = PastExperienceMapper.Map(pastExperience);

                    bo.Hobbies = HobbyMapper.Map(hobbies);

                    bo.EducationDetails = EducationDetailsMapper.Map(eductionDetails);

                    return bo;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public async Task<PaginatedList<BOTalentRefactored>> GetFilteredList(int? pageNumber, string sortField, string sortOrder, int? pageSize, BOActiveSearchFilter filters, int organization = 0)
        {
            try
            {
                PaginatedList<Talent> result = await _talentRefactoredRepository.GetFilteredList(ActiveSearchFilterMapper.Map(filters), pageNumber, sortField, sortOrder, pageSize, organization);

                var allLabels = await _talentPropertyRepository.GetAllLabels();

                return new PaginatedList<BOTalentRefactored>
                {
                    CurrentPage = result.CurrentPage,
                    From = result.From,
                    PageSize = result.PageSize,
                    To = result.To,
                    TotalCount = result.TotalCount,
                    TotalPages = result.TotalPages,
                    ItemIndexes = result.ItemIndexes,
                    Items = result.Items.Select((item) => new BOTalentRefactored()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Organization = (item.Organization != null) ? OrganizationMapper.Map(item.Organization) : null,
                        LaborMarketRegion = (item.LaborMarketRegion != null) ? LaborMarketRegionMapper.Map(item.LaborMarketRegion) : null,
                        JobTitle = item.JobTitle,
                        Description = item.Description,
                        Education = item.Education,
                        Municipality = item.Municipality,
                        ProfilePhotoRef = item.ProfilePhotoRef,
                        PitchUrl = (!item.PitchUrl.Equals("") && !item.PitchUrl.Equals("null")) ? item.PitchUrl : null,
                        LoopUrl = (!item.LoopUrl.Equals("")) ? item.LoopUrl : null,
                        TravelDistance = item.TravelDistance,
                        AvailableHours = item.AvailableHours,
                        TalentProperties = GetMainAndSubCategories(item.TalentPropertyMainCategoryLinks, allLabels)

                    }).ToList()
                };
            }
            catch (Exception ex)
            {                
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }            
        }

        public async Task<List<BOTalentRefactored>> GetAllFavourites(int[] favourites, int organization)
        {
            List<BOTalentRefactored> businessObjects = new List<BOTalentRefactored>();

            if(favourites.Length == 0)
            {
                return businessObjects;
            }

            var records = await _talentRefactoredRepository.GetAllByIds(favourites.ToList(), organization);

            foreach (var record in records)
            {
                BOTalentRefactored bo = TalentRefactoredMapper.Map(record);

                List<BOTalentPropertyMainCategory> data = new List<BOTalentPropertyMainCategory>();

                if (record.TalentPropertyMainCategoryLinks.Count() > 0)
                {
                    List<int> labelIds = GetLabelIds(record.TalentPropertyMainCategoryLinks);
                    var labels = await _talentPropertyRepository.GetLabelsByIds(labelIds);

                    foreach (var mainCategory in record.TalentPropertyMainCategoryLinks)
                    {
                        data.Add(TalentPropertyMapper.Map(mainCategory, labels));
                    }
                }

                bo.TalentProperties = data;

                businessObjects.Add(bo);
            }

            return businessObjects;
        }


    }
}
