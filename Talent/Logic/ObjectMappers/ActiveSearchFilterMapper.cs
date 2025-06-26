using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentDataAccess.DataAccess.Repositories;

namespace TalentLogic.Logic.ObjectMappers
{
    public class ActiveSearchFilterMapper
    {

        public static ActiveSearchFilter Map(BOActiveSearchFilter bo)
        {
            ActiveSearchFilter model = new ActiveSearchFilter();
            model.Provinces = RemoveHTML(bo.Provinces);
            model.EducationLevels = RemoveHTML(bo.EducationLevels);
            model.FilterProperties = bo.FilterProperties;
            model.AvailableHoursMin = (bo.AvailableHoursMin < 8) ? 8 : bo.AvailableHoursMin;
            model.AvailableHoursMax = (bo.AvailableHoursMax > 40) ? 40 : bo.AvailableHoursMax;
            model.WorkLocations = RemoveHTML(bo.WorkLocations);
            model.TravelDistance = (bo.TravelDistance < 0) ? 0 : bo.TravelDistance;
            model.SkillLevels = RemoveHTML(bo.SkillLevels);
            model.Companies = RemoveHTML(bo.Companies);
            model.LaborMarketRegions = RemoveHTML(bo.LaborMarketRegions);

            return model;
        }

        private static List<string> RemoveHTML(List<string> items)
        {
            for(int i = 0; i < items.Count; i++)
            {
                items[i] = Regex.Replace(items[i], "<.*?>", String.Empty);
            }

            return items;
        }

    }
}
