﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.Logic.BusinessObjects;

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
                bo.DateFrom = item.DateFrom;
                bo.DateTill = item.DateTill;
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
                model.DateFrom = item.DateFrom;
                model.DateTill = item.DateTill;
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
