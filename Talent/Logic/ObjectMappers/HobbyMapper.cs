using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.ObjectMappers
{
    public class HobbyMapper
    {

        public static List<BOHobby> Map(List<Hobby> models)
        {
            List<BOHobby> list = new List<BOHobby>();

            foreach (var model in models)
            {
                BOHobby bo = new BOHobby();
                bo.Name = model.Name;
                bo.Order = model.Order;
                bo.TalentId = model.TalentId;

                list.Add(bo);
            }

            return list;
        }

        public static List<Hobby> Map(List<BOHobby> businessObjects)
        {
            List<Hobby> models = new List<Hobby>();

            foreach (var bo in businessObjects)
            {
                Hobby model = new Hobby();
                model.Name = bo.Name;
                model.Order = bo.Order;
                model.TalentId = bo.TalentId;

                models.Add(model);
            }

            return models;
        }

    }
}
