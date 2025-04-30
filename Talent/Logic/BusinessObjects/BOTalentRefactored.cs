using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOTalentRefactored
    {
        public int? Id { get; set; }
        public string Initials { get; set; } = string.Empty;
        public string GivenName { get; set; } = string.Empty;
        public string NamePrefix { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string StreetName { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string HouseNumberSuffix { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Municipality { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string countryCode { get; set; } = string.Empty;
        public int? OrganisationId { get; set; }
        public BOOrganization? Organization { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        //public string CharacterTraits { get; set; } = string.Empty;
        public string DateOfBirth { get; set; }
        public string Education { get; set; } = string.Empty;
        public string ProfilePhotoRef { get; set; } = string.Empty;
        public string? PitchUrl { get; set; } = string.Empty;
        public string? LoopUrl { get; set; } = string.Empty;
        public string? CvUrl { get; set; } = string.Empty;
        public string? LinkedInUrl { get; set; } = string.Empty;
        public string? ContactOptions { get; set; } = string.Empty;
        public int TravelDistance { get; set; }
        public string DesiredWorkLocation { get; set; } = string.Empty;
        public decimal AvailableHours { get; set; }
        public List<BOTalentPropertyMainCategory> TalentProperties { get; set; }
        public List<BOPastExperience> PastExperience {  get; set; }
        public List<BOHobby> Hobbies { get; set; }
        public List<BOEducationDetail> EducationDetails { get; set; }
        public bool IsProfileVisible { get; set; }
        public bool FoundJob { get; set; }
        public string WorksAtCompany { get; set; }

    }
}
