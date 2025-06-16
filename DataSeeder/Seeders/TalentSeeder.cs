using System;
using System.Linq;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace DataSeeder.Seeders
{
    public static class TalentSeeder
    {
        public static async Task Seed(TalentDbContext dbContext)
        {
            var talentsToSeed = new[]
            {
                new Talent
                {
                    Name = "John Doe",
                    Initials = "JD",
                    GivenName = "John",
                    Surname = "Doe",
                    NamePrefix = "",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Municipality = "Amsterdam",
                    Province = "Noord-Holland",
                    Street = "Main Street",
                    HouseNumber = "1",
                    HouseNumberSuffix = "",
                    PostalCode = "1000AA",
                    CountryCode = "NL",
                    Email = "john.doe@example.com",
                    PhoneNumber = "0612345678",
                    LinkedInUrl = "",
                    ContactOptions = "",
                    ProfilePhotoRef = "",
                    PitchUrl = "",
                    LoopUrl = "",
                    CvUrl = "",
                    OrganisationId = null,
                    JobTitle = "Software Developer",
                    Description = "Experienced .NET developer.",
                    Education = "Bachelor Computer Science",
                    TravelDistance = 50,
                    DesiredWorkLocation = "Amsterdam",
                    AvailableHours = 40,
                    FoundJob = false,
                    WorksAtCompany = "",
                    IsProfileVisible = true
                },
                new Talent
                {
                    Name = "Jane Smith",
                    Initials = "JS",
                    GivenName = "Jane",
                    Surname = "Smith",
                    NamePrefix = "",
                    DateOfBirth = new DateTime(1992, 5, 15),
                    Municipality = "Rotterdam",
                    Province = "Zuid-Holland",
                    Street = "Second Street",
                    HouseNumber = "2",
                    HouseNumberSuffix = "A",
                    PostalCode = "2000BB",
                    CountryCode = "NL",
                    Email = "jane.smith@example.com",
                    PhoneNumber = "0623456789",
                    LinkedInUrl = "",
                    ContactOptions = "",
                    ProfilePhotoRef = "",
                    PitchUrl = "",
                    LoopUrl = "",
                    CvUrl = "",
                    OrganisationId = null,
                    JobTitle = "Data Analyst",
                    Description = "Expert in data analysis.",
                    Education = "Master Data Science",
                    TravelDistance = 30,
                    DesiredWorkLocation = "Rotterdam",
                    AvailableHours = 36,
                    FoundJob = false,
                    WorksAtCompany = "",
                    IsProfileVisible = true
                }
        // Add more Talent objects here as needed
            };

            foreach (var talent in talentsToSeed)
            {
                if (!dbContext.Talents.Any(t => t.Name == talent.Name))
                {
                    dbContext.Talents.Add(talent);
                }
            }

            await dbContext.SaveChangesAsync();
        }

    }
}
