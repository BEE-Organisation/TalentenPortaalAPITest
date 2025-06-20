using System;
using System.Collections.Generic;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.Logic.BusinessObjects;
using CrossCuttingConcerns.Validation;


namespace TalentLogic.Logic.ObjectMappers
{
    public class EducationDetailsMapper
    {

        public static List<BOEducationDetail> Map(ICollection<EducationDetail> items)
        {
            List<BOEducationDetail> list = new List<BOEducationDetail>();

            foreach (var item in items)
            {
                BOEducationDetail bo = new BOEducationDetail();
                bo.DateFrom = item.DateFrom.HasValue ? item.DateFrom.Value.ToString("dd-MM-yyyy") : string.Empty;
                bo.DateTill = item.DateTill.HasValue ? item.DateTill.Value.ToString("dd-MM-yyyy") : string.Empty;
                bo.Name = item.Name;
                bo.Institution = item.Institution;
                bo.Comments = item.Comments;

                list.Add(bo);
            }

            return list;
        }

        public static List<EducationDetail> Map(List<BOEducationDetail> items, int talentId)
        {
            List<EducationDetail> list = new List<EducationDetail>();

            foreach (var item in items)
            {
                EducationDetail model = new EducationDetail();
                
                DateOnly? dateFrom = string.IsNullOrEmpty(item.DateFrom)
                ? null 
                : DateOnly.FromDateTime(DateTime.ParseExact(item.DateFrom, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture));
                                
                DateOnly? dateTill = string.IsNullOrEmpty(item.DateTill)
                ? null 
                : DateOnly.FromDateTime(DateTime.ParseExact(item.DateTill, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture));


                if (dateFrom.HasValue && !ChronologyValidator.IsValidChronology(dateFrom.Value, dateTill))
                {
                    throw new ArgumentException($"EducationDetail: DateFrom ({dateFrom}) must be before or equal to DateTill ({dateTill}).");
                }

                model.DateFrom = dateFrom;
                model.DateTill = dateTill;
                model.Name = item.Name;
                model.Institution = item.Institution;
                model.Comments = item.Comments;
                model.TalentId = talentId;

                list.Add(model);
            }
            
            return list;
        }

    }
}
