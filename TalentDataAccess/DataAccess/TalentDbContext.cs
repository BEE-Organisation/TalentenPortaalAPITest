using Microsoft.EntityFrameworkCore;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentDataAccess.DataAccess.ExampleData;

namespace TalentDataAccess.DataAccess
{
    public class TalentDbContext : DbContext
    {
        public DbSet<Talent> Talents { get; set; }
        public DbSet<EducationDetail> EducationDetails { get; set; }
        public DbSet<PastExperience> PastExperiences { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<TalentPropertyLabel> TalentPropertyLabels { get; set; }
        public DbSet<TalentPropertyMainCategoryLink> TalentPropertyMainCategoryLinks { get; set; }        
        public DbSet<TalentPropertySubCategoryLink> TalentPropertySubCategoryLinks { get; set; }
        public DbSet<Organization> Organizations { get; set; }

        public DbSet<Company> Companies { get; set; }
        public DbSet<VacancyComplete> Vacancies { get; set; }
        public DbSet<VacancyOffer> VacancyOffers { get; set; }
        public DbSet<VacancyDemand> VacancyDemands { get; set; }
        public DbSet<VacancyDemandDetail> VacancyDemandDetails { get; set; }
        public DbSet<VacancyText> VacancyTexts { get; set; }



        public TalentDbContext(DbContextOptions<TalentDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                       
            modelBuilder.Entity<TalentPropertyMainCategoryLink>()
               .HasMany(x => x.TalentPropertySubCategoryLinks)
               .WithOne(x => x.TalentPropertyMainCategoryLink);

            //Use unique values for labels.
            modelBuilder.Entity<TalentPropertyLabel>()
                .HasIndex(x => x.Name)
                .IsUnique();

            //Create example data.            
            modelBuilder.Entity<EducationDetail>().HasData(
                CreateEducationDetails.Create()
            ); ;

            modelBuilder.Entity<Talent>().HasData(
                CreateTalentNewData.Create()
            );

            modelBuilder.Entity<TalentPropertyLabel>().HasData(
                CreateTalentPropertyCategoryLabels.Create()
            );

            modelBuilder.Entity<PastExperience>().HasData(
                CreatePastExperiences.Create()
            );

            modelBuilder.Entity<TalentPropertyMainCategoryLink>().HasData(
                CreateTalentPropertyMainCategoryLinks.Create()
            );

            modelBuilder.Entity<Hobby>().HasData(
                CreateHobbies.Create()
            );

            modelBuilder.Entity<Organization>().HasData(
                CreateOrganizations.Create()
            );

            modelBuilder.Entity<Company>().HasData(
                CreateCompanies.Create()
            );

            modelBuilder.Entity<VacancyOffer>().HasData(
                CreateVacancyOffers.Create()
            );

            modelBuilder.Entity<VacancyDemand>().HasData(
                CreateVacancyDemands.Create()
            );

            modelBuilder.Entity<VacancyDemandDetail>().HasData(
                CreateVacancyDemandDetails.Create()
            );

            modelBuilder.Entity<VacancyText>().HasData(
                CreateVacancyText.Create()
            );

            modelBuilder.Entity<VacancyComplete>().HasData(
                CreateVacanciesComplete.Create()
            );

        }
    }

}
