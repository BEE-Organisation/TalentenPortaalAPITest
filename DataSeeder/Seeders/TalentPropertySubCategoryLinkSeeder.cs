using System.Collections.Generic;
using System.Linq;
using TalentDataAccess.DataAccess.DataAccessObjects;
using Microsoft.EntityFrameworkCore;
using DataSeeder.Seeders;

namespace TalentDataAccess.DataAccess.DataSeeders
{
    public static class TalentPropertySubCategoryLinkSeeder
    {
        public static async Task Seed(TalentDbContext context)
        {
            var subCategoryLinks = new List<TalentPropertySubCategoryLink>
                        {
                            new TalentPropertySubCategoryLink
                            {
                                TalentPropertyLabelId = 1,
                                SkillLevel = 3,
                                Order = 1,

                            },
                            new TalentPropertySubCategoryLink
                            {
                                Id = 2,
                                TalentPropertyLabelId = 2,
                                SkillLevel = 2,
                                Order = 2
                                // TalentPropertyMainCategoryLink is not set
                            },
                            new TalentPropertySubCategoryLink
                            {
                                Id = 3,
                                TalentPropertyLabelId = 3,
                                SkillLevel = 5,
                                Order = 3
                                // TalentPropertyMainCategoryLink is not set
                            }
                        };

            foreach (var link in subCategoryLinks)
            {
                if (!await context.TalentPropertySubCategoryLinks.AnyAsync(x => x.Id == link.Id))
                {
                    await context.TalentPropertySubCategoryLinks.AddAsync(link);
                }
            }

            await context.SaveChangesAsync();
        }
    }
}
