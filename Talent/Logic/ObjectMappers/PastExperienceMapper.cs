using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                bo.DateFrom = model.DateFrom;
                bo.DateTill = model.DateTill;
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

                model.DateFrom = businessObject.DateFrom;
                model.DateTill = businessObject.DateTill;
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
