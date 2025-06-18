using System;
using System.Collections.Generic;
using CrossCuttingConcerns.Validation;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.ObjectMappers
{
    public class PastExperienceMapper
    {

        public static List<BOPastExperience> Map(List<PastExperience> models)
        {
            List<BOPastExperience> businessObjects = new List<BOPastExperience>();

            foreach (var model in models)
            {
                BOPastExperience bo = new BOPastExperience();
                bo.Id = model.Id;
                bo.DateFrom = model.DateFrom.HasValue ? model.DateFrom.Value.ToString("dd-MM-yyyy") : string.Empty;
                bo.DateTill = model.DateTill.HasValue ? model.DateTill.Value.ToString("dd-MM-yyyy") : string.Empty;
                bo.Company = model.Company;
                bo.Function = model.Function;
                bo.Tasks = model.Tasks;
                bo.Description = model.Description;
                bo.TalentId = model.TalentId;
                businessObjects.Add(bo);
            }            

            return businessObjects;
        }

        public static List<PastExperience> Map(List<BOPastExperience> businessObjects)
        {
            List<PastExperience> models = new List<PastExperience>();

            foreach (var businessObject in businessObjects)
            {
                PastExperience model = new PastExperience();

                if (businessObject.Id != null)
                {
                    model.Id = businessObject.Id ?? 0;
                }

                DateOnly? dateFrom = string.IsNullOrEmpty(businessObject.DateFrom)
                    ? null
                    : DateOnly.FromDateTime(DateTime.ParseExact(businessObject.DateFrom, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture));
                model.DateFrom = dateFrom;

                DateOnly? dateTill = string.IsNullOrEmpty(businessObject.DateTill)
                    ? null
                    : DateOnly.FromDateTime(DateTime.ParseExact(businessObject.DateTill, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture));
                model.DateTill = dateTill;

                if (dateFrom.HasValue && !ChronologyValidator.IsValidChronology(dateFrom.Value, dateTill))
                {
                    throw new ArgumentException($"EducationDetail: DateFrom ({dateFrom}) must be before or equal to DateTill ({dateTill}).");
                }

                model.Company = businessObject.Company;
                model.Function = businessObject.Function;
                model.Tasks = businessObject.Tasks;
                model.Description = businessObject.Description;
                model.TalentId = businessObject.TalentId;

                models.Add(model);
            }
            
            return models;
        }


    }
}
