using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.ObjectMappers
{
    public class VacancyCompleteMapper
    {
        private static Dictionary<string, SalaryType> _salaryTypes = new Dictionary<string, SalaryType>()
        {
            { "UNKNOWN", SalaryType.UNKNOWN },
            { "FIXED", SalaryType.FIXED },
            { "FLEXIBLE", SalaryType.FLEXIBLE },
            { "CONSULTATION", SalaryType.CONSULTATION },
            { "FROM", SalaryType.FROM },
            { "UNTIL", SalaryType.UNTIL },
            { "FROM_UNTIL", SalaryType.FROM_UNTIL },
        };


        private static Dictionary<string, ContractType> _contractTypes = new Dictionary<string, ContractType>() 
        {
            { "UNKNOWN", ContractType.UNKNOWN },
            { "FIXED", ContractType.FIXED },
            { "NOT_FIXED", ContractType.NOT_FIXED },
            { "FLEXIBLE", ContractType.FLEXIBLE },
            { "TEMPORARY", ContractType.TEMPORARY },
            { "INTERNSHIP", ContractType.INTERNSHIP }
        };

        private static Dictionary<string, HourType> _hourTypes = new Dictionary<string, HourType>()
        {
            { "UNKNOWN", HourType.UNKNOWN },
            { "FIXED", HourType.FIXED },
            { "FLEXIBLE", HourType.FLEXIBLE },
            { "CONSULTATION", HourType.CONSULTATION },
        };

        public static VacancyComplete Map(BOVacancyComplete bo)
        {
            VacancyComplete model = new VacancyComplete();

            if(bo.Id != null)
            {
                model.Id = bo.Id ?? 0;
            }

            model.Title = bo.Title;
            model.Region = bo.Region;
            model.IsEnabled = bo.IsEnabled;
            model.Created = DateTime.Now;

            //Company.
            //model.Company = CompanyMapper.Map(bo.Company);
            model.CompanyId = bo.Company.Id;

            //VacancyOffer
            model.VacancyOffer = new VacancyOffer();

            if(bo.VacancyOffer.Id != null)
            {
                model.VacancyOffer.Id = bo.VacancyOffer.Id ?? 0;
                model.VacancyOfferId = bo.VacancyOffer.Id;
            }

            model.VacancyOffer.SalaryMin = bo.VacancyOffer.SalaryMin;
            model.VacancyOffer.SalaryMax = bo.VacancyOffer.SalaryMax;

            SalaryType salaryType;
            bool isSalaryTypeFound = _salaryTypes.TryGetValue(bo.VacancyOffer.SalaryType, out salaryType);
            model.VacancyOffer.SalaryType = isSalaryTypeFound ? salaryType : SalaryType.UNKNOWN;

            model.VacancyOffer.MonthsMin = bo.VacancyOffer.MonthsMin;
            model.VacancyOffer.MonthsMax = bo.VacancyOffer.MonthsMax;

            ContractType contractType;
            bool isContractType = _contractTypes.TryGetValue(bo.VacancyOffer.ContractType, out contractType);
            model.VacancyOffer.ContractType = isContractType ? contractType : ContractType.UNKNOWN;

            model.VacancyOffer.SecondaryConditions = GetPropertyIds(bo.VacancyOffer.SecondaryConditions);

            //VacancyDemand
            model.VacancyDemand = new VacancyDemand();

            if(bo.VacancyDemand.Id != null)
            {
                model.VacancyDemand.Id = bo.VacancyDemand.Id ?? 0;
                model.VacancyDemandId = bo.VacancyDemand.Id;
            }
            model.VacancyDemand.HoursMin = bo.VacancyDemand.HoursMin;
            model.VacancyDemand.HoursMax = bo.VacancyDemand.HoursMax;

            HourType hourType;
            bool isHourTypeFound = _hourTypes.TryGetValue(bo.VacancyDemand.HourType, out hourType);
            model.VacancyDemand.HourType = isHourTypeFound ? hourType : HourType.UNKNOWN;

            model.VacancyDemand.EducationLevel = bo.VacancyDemand.EducationLevel;
            model.VacancyDemand.SkillLevel = bo.VacancyDemand.SkillLevel;

            //VacancyDemandDetail
            model.VacancyDemandDetail = new VacancyDemandDetail();

            if(bo.VacancyDemandDetail.Id != null)
            {
                model.VacancyDemandDetail.Id = bo.VacancyDemandDetail.Id ?? 0;
                model.VacancyDemandDetailId = model.VacancyDemandDetail.Id;
            }

            model.VacancyDemandDetail.ParentProperties = GetParentPropertyIds(bo.VacancyDemandDetail.Properties);
            model.VacancyDemandDetail.ChildProperties = GetChildPropertyIds(bo.VacancyDemandDetail.Properties);

            //VacancyText
            model.VacancyText = new VacancyText();

            if(bo.VacancyText.Id != null)
            {
                model.VacancyText.Id = bo.VacancyText.Id ?? 0;
                model.VacancyTextId = model.VacancyText.Id;
            }

            model.VacancyText.Text = bo.VacancyText.Text;
            model.VacancyText.ShowCompanyInfo = bo.VacancyText.ShowCompanyInfo;

            return model;
        }

        public static BOVacancyComplete Map(VacancyComplete model, List<TalentPropertyLabel> propertyLabels)
        {
            BOVacancyComplete bo = new BOVacancyComplete();
            bo.Id = model.Id;
            bo.Title = model.Title;
            bo.Region = model.Region;
            bo.IsEnabled = model.IsEnabled;
            bo.Created = model.Created.ToString("dd-MM-yyyy hh:mm:ss");

            //Company
            bo.Company = CompanyMapper.Map(model.Company, false);

            //VacancyOffer
            bo.VacancyOffer = new BOVacancyOffer();
            bo.VacancyOffer.Id = model.VacancyOffer.Id;
            bo.VacancyOffer.SalaryMin = model.VacancyOffer.SalaryMin;
            bo.VacancyOffer.SalaryMax = model.VacancyOffer.SalaryMax;
            bo.VacancyOffer.SalaryType = model.VacancyOffer.SalaryType.ToString();
            bo.VacancyOffer.MonthsMin = model.VacancyOffer.MonthsMin;
            bo.VacancyOffer.MonthsMax = model.VacancyOffer.MonthsMax;
            bo.VacancyOffer.ContractType = model.VacancyOffer.ContractType.ToString();
            bo.VacancyOffer.SecondaryConditions = GetProperties(propertyLabels, model.VacancyOffer.SecondaryConditions);

            //VacancyDemand
            if(model.VacancyDemand != null)
            {
                bo.VacancyDemand = new BOVacancyDemand();
                bo.VacancyDemand.Id = model.VacancyDemand.Id;
                bo.VacancyDemand.HoursMin = model.VacancyDemand.HoursMin;
                bo.VacancyDemand.HoursMax = model.VacancyDemand.HoursMax;
                bo.VacancyDemand.HourType = model.VacancyDemand.HourType.ToString();
                bo.VacancyDemand.EducationLevel = model.VacancyDemand.EducationLevel;
                bo.VacancyDemand.SkillLevel = model.VacancyDemand.SkillLevel;
            }

            //VacancyDemandDetail
            if (model.VacancyDemandDetail != null)
            {
                bo.VacancyDemandDetail = new BOVacancyDemandDetail();
                bo.VacancyDemandDetail.Id = model.VacancyDemandDetail.Id;

               int[] allIds = GetAllIds(model.VacancyDemandDetail.ParentProperties, model.VacancyDemandDetail.ChildProperties);
               bo.VacancyDemandDetail.Properties = GetProperties(propertyLabels, allIds);
            }

            //VacancyText
            if(model.VacancyText != null)
            {
                bo.VacancyText = new BOVacancyText();
                bo.VacancyText.Id = model.VacancyText.Id;
                bo.VacancyText.Text = model.VacancyText.Text;
                bo.VacancyText.ShowCompanyInfo = model.VacancyText.ShowCompanyInfo;
            }

            return bo;
        }

        private static int[] GetPropertyIds(List<BOTalentPropertyLabel> items)
        {
            List<int> list = new List<int>();

            foreach (var item in items)
            {
                var id = item.Id ?? 0;

                if(!list.Contains(id))
                {
                    list.Add(id);
                }                
            }

            return list.ToArray();
        }

        private static int[] GetParentPropertyIds(List<BOTalentPropertyLabel> items)
        {
            List<int> list = new List<int>();

            foreach (var item in items)
            {
                var id = item.Id ?? 0;

                if (!list.Contains(id) && item.ParentId == null)
                {
                    list.Add(id);
                }
            }

            return list.ToArray();
        }

        private static int[] GetChildPropertyIds(List<BOTalentPropertyLabel> items)
        {
            List<int> list = new List<int>();

            foreach (var item in items)
            {
                var id = item.Id ?? 0;

                if (!list.Contains(id) && item.ParentId != null)
                {
                    list.Add(id);
                }
            }

            return list.ToArray();
        }

        private static List<BOTalentPropertyLabel> GetProperties(List<TalentPropertyLabel> items, int[] ids)
        {
            List<BOTalentPropertyLabel> list = new List<BOTalentPropertyLabel>();

            foreach(int id in ids)
            {
                BOTalentPropertyLabel prop = SearchProperty(items, id);

                if(prop != null)
                {
                    list.Add(prop);
                }
            }

            return list;
        }


        private static BOTalentPropertyLabel? SearchProperty(List<TalentPropertyLabel> items, int id)
        {
            foreach (var item in items)
            {
                if(item.Id == id)
                {
                    return TalentPropertyLabelMapper.Map(item);
                }
            }

            return null;
        }

        private static int[] GetAllIds(int[] parentIds, int[] childIds)
        {
            int[] ids = new int[parentIds.Length + childIds.Length];
            int index = 0;

            if(parentIds.Length > 0)
            {
                foreach(int parentId in parentIds)
                {
                    ids[index] = parentId;
                    index++;
                }
            }

            if (childIds.Length > 0)
            {
                foreach (int childId in childIds)
                {
                    ids[index] = childId;
                    index++;
                }
            }

            return ids;
        }

    }
    

}