using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.ObjectMappers
{
    public class TalentPropertyLabelMapper
    {

        public static TalentPropertyLabel Map(BOTalentPropertyLabel bo)
        {
            TalentPropertyLabel model = new TalentPropertyLabel();

            if(bo.Id != null)
            {
                model.Id = bo.Id ?? 0;
            }

            model.Name = bo.Name;
            model.ParentId = bo.ParentId;

            return model;
        }


        public static BOTalentPropertyLabel Map(TalentPropertyLabel model)
        {
            BOTalentPropertyLabel bo = new BOTalentPropertyLabel();
            bo.Id = model.Id;
            bo.Name = model.Name;
            bo.ParentId = model.ParentId;

            return bo;
        }





    }

}
