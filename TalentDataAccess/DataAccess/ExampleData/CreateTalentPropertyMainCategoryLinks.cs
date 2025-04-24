using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.ExampleData
{
    public class CreateTalentPropertyMainCategoryLinks
    {

        public static List<TalentPropertyMainCategoryLink> Create()
        {
            List<TalentPropertyMainCategoryLink> list = new List<TalentPropertyMainCategoryLink>();

            int amountOfTalentIds = 14;
            int amountOfMainCategories = 8;
            int index = 1;


            for (int i = 0; i < amountOfTalentIds; i++)
            {
                for (int j = 0; j < amountOfMainCategories; j++)
                {
                    TalentPropertyMainCategoryLink data = new TalentPropertyMainCategoryLink();
                    data.Id = index;
                    data.TalentPropertyLabelId = (j + 1);
                    data.TalentId = (i + 1);
                    index++;

                    list.Add(data);
                }
            }


            return list;
        }


    }

}
