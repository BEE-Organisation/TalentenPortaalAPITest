using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.ObjectMappers
{
    public static class OrganizationMapper
    {

        public static BOOrganization Map(Organization model)
        {
            BOOrganization bo = new BOOrganization();
            bo.Id = model.Id;
            bo.Name = model.Name;
            bo.Description = model.Description;
            bo.Theme = model.Theme;
            bo.StyleSheet = ToEnumMember<Theme>(model.Theme);

            return bo;
        }

        public static Organization Map(BOOrganization bo)
        {
            Organization model = new Organization();

            if(bo.Id != null)
            {
                model.Id = bo.Id ?? 0;
            }
            
            model.Name = bo.Name;
            model.Description = bo.Description;
            model.Theme = bo.Theme;

            return model;
        }

        public static string GetStyleName(Theme theme)
        {
            return ToEnumMember<Theme>(theme) ?? "default";
        }

        public static string? ToEnumMember<T>(this T value) where T : Enum
        {
            return typeof(T)
                .GetTypeInfo()
                .DeclaredMembers
                .SingleOrDefault(x => x.Name == value.ToString())?
                .GetCustomAttribute<EnumMemberAttribute>(false)?
                .Value;
        }

    }

}
