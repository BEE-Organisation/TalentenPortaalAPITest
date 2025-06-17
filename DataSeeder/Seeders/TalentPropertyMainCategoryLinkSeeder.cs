using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TalentDataAccess.DataAccess;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace DataSeeder.Seeders
{
    internal class TalentPropertyMainCategoryLinkSeeder
    {
        public static async Task Seed(TalentDbContext context)
        {
            var mainCategoryLinks = new List<TalentPropertyMainCategoryLink>
            {
                new TalentPropertyMainCategoryLink
                {
 
                    TalentPropertyLabelId = 1, 
                    TalentId = 1,
                },
                new TalentPropertyMainCategoryLink
                {

                    TalentPropertyLabelId = 2,
                    TalentId = 1,
                },
                new TalentPropertyMainCategoryLink
                {

                    TalentPropertyLabelId = 3,
                    TalentId = 2, 
                }
            };

            foreach (var link in mainCategoryLinks)
            {
                if (!await context.TalentPropertyMainCategoryLinks.AnyAsync(x => x.Id == link.Id))
                {
                    await context.TalentPropertyMainCategoryLinks.AddAsync(link);
                }
            }

            await context.SaveChangesAsync();
        }
    }
}
