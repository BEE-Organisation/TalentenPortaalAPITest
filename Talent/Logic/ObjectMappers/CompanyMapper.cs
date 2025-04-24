using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.ObjectMappers
{
    public class CompanyMapper
    {

        public static BOCompany Map(Company model, bool addCreator)
        {
            BOCompany bo = new BOCompany();
            bo.Id = model.Id;
            bo.Name = model.Name;
            bo.Description = model.Description;
            bo.CompanyLogoUrl = model.CompanyLogoUrl;

            if(addCreator)
            {
                bo.Creator = model.Creator;
                bo.Email = model.Email;
            }            

            return bo;
        }

        public static Company Map(BOCompany bo)
        {
            Company model = new Company();

            if(bo.Id != null)
            {
                model.Id = bo.Id ?? 0;
            }
            model.Name = bo.Name;
            model.Description = bo.Description;
            model.CompanyLogoUrl = bo.CompanyLogoUrl;
            model.Creator = bo.Creator != null ? bo.Creator.ToString() : string.Empty;   
            model.Email = bo.Email != null ? bo.Email.ToString() : string.Empty;

            return model;
        }

    }
}
