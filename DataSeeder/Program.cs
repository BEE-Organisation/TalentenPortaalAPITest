using DataSeeder.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess;
using TalentDataAccess.DataAccess.DataSeeders;

namespace DataSeeder
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
#if DEBUG
            //var DatabaseConnectionString = "Host=localhost,5432;Password=Testen2024!;Persist Security Info=True;Username=danny;Database=postgres";
            //var DatabaseConnectionString = "Host=localhost;Port=5433;Database=TalentenPortaal;Username=postgres;Password=Testen2025!;Persist Security Info=True;";
            var DatabaseConnectionString = "Host=162.55.181.242;Port=5433;Password=dab2b61743ca034eae37;Persist Security Info=True;Username=postgres;Database=Dev-Pim";
#else
            var DatabaseConnectionString =
                "Host=162.55.181.242;Port=5433;Password=dab2b61743ca034eae37;Persist Security Info=True;Username=postgres;Database=it-talenten-portaal-test";
#endif

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<TalentDbContext>(options =>
                options.UseNpgsql(DatabaseConnectionString)
            );

            var provider = serviceCollection.BuildServiceProvider();
            
            var mainDbContext = provider.GetService<TalentDbContext>();

            try
            {
                if (mainDbContext != null)
                {
                    await mainDbContext.Database.EnsureCreatedAsync();

                    //Seed with the following seeders

                    await TalentSeeder.Seed(mainDbContext);
                    await TalentPropertyLabelSeeder.Seed(mainDbContext);
                    await TalentPropertyMainCategoryLinkSeeder.Seed(mainDbContext);
                    await TalentPropertySubCategoryLinkSeeder.Seed(mainDbContext);


                    await mainDbContext.DisposeAsync();
                    Console.WriteLine("Database gevuld met data. Druk op een knop om af te sluiten.");
                }
                else
                {
                    Console.WriteLine("Kan geen DbContext aanmaken.");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine("Kan de database niet vullen met data. Druk op een knop om af te sluiten.");
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
