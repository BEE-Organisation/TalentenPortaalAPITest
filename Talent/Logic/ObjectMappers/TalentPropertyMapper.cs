using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.ObjectMappers
{
    public class TalentPropertyMapper
    {

        public static TalentPropertyMainCategoryLink Map(BOTalentPropertyMainCategory bo)
        {
            TalentPropertyMainCategoryLink model = new TalentPropertyMainCategoryLink();

            model.TalentPropertyLabelId = bo.TalentPropertyLabelId ?? 0;
            model.TalentId = bo.TalentId;

            if(bo.TalentPropertySubCategoryLinks.Count() > 0)
            {
                model.TalentPropertySubCategoryLinks = ConvertListToCollection(bo.TalentPropertySubCategoryLinks);
            }            

            return model;
        }

        public static BOTalentPropertyMainCategory Map(TalentPropertyMainCategoryLink model, List<TalentPropertyLabel> labels)
        {
            BOTalentPropertyMainCategory bo = new BOTalentPropertyMainCategory();
            bo.Id = model.Id;
            bo.TalentPropertyLabelId = model.TalentPropertyLabelId;
            TalentPropertyLabel label = labels.SingleOrDefault(x => x.Id == model.TalentPropertyLabelId);
            bo.TalentPropertyLabelName = (label != null) ? label.Name : "";

            if(model.TalentPropertySubCategoryLinks.Count() > 0)
            {
                bo.TalentPropertySubCategoryLinks = ConvertCollectionToList(model.TalentPropertySubCategoryLinks, labels);
            }

            return bo;
        }

        public static ICollection<TalentPropertySubCategoryLink> ConvertListToCollection(List<BOTalentPropertySubCategory> items)
        {
            ICollection<TalentPropertySubCategoryLink> collection = new List<TalentPropertySubCategoryLink>();

            foreach(var item in items)
            {
                TalentPropertySubCategoryLink model = new TalentPropertySubCategoryLink();
                
                model.TalentPropertyLabelId = item.TalentPropertyLabelId ?? 0;
                model.SkillLevel = item.SkillLevel;
                model.Order = item.Order;


                collection.Add(model);
            }

            return collection;
        }

        public static List<BOTalentPropertySubCategory> ConvertCollectionToList(ICollection<TalentPropertySubCategoryLink> colection, List<TalentPropertyLabel> labels)
        {
            List<BOTalentPropertySubCategory> list = new List<BOTalentPropertySubCategory>();

            foreach(var item in colection)
            {
                BOTalentPropertySubCategory bo = new BOTalentPropertySubCategory();
                bo.Id = item.Id;
                bo.TalentPropertyLabelId = item.TalentPropertyLabelId;
                TalentPropertyLabel label = labels.SingleOrDefault(x => x.Id == item.TalentPropertyLabelId);
                bo.TalentPropertyLabelName = (label != null) ? label.Name : "";
                bo.SkillLevel = item.SkillLevel;
                bo.Order = item.Order;
                bo.MainCategoryId = item.TalentPropertyMainCategoryLink.Id;

                list.Add(bo);
            }

            return list;
        }

        public static TalentPropertyLabel CreateLabel(string name, int? parentId)
        {
            TalentPropertyLabel label = new TalentPropertyLabel();
            label.Name = name;
            label.ParentId = parentId;

            return label;
        }

    }

}
