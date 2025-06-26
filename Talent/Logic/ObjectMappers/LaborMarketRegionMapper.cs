using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.ObjectMappers
{
    public static class LaborMarketRegionMapper
    {
        public static BOLaborMarketRegion Map(LaborMarketRegion model)
        {
            BOLaborMarketRegion bo = new BOLaborMarketRegion();
            bo.Id = model.Id;
            bo.Name = model.Name;

            return bo;
        }

        public static LaborMarketRegion Map(BOLaborMarketRegion bo)
        {
            LaborMarketRegion model = new LaborMarketRegion();

            if (bo.Id != null)
            {
                model.Id = bo.Id ?? 0;
            }

            model.Name = bo.Name;

            return model;
        }
    }
}
