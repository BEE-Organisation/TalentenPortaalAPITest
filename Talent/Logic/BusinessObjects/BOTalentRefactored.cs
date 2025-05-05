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

        #region Personal Information
        public string Name { get; set; } = string.Empty; // TODO: to be removed
        public string Initials { get; set; } = string.Empty; // TODO: use when field is created
        public string GivenName { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string NamePrefix { get; set; } = string.Empty;
        public string DateOfBirth { get; set; }
        #endregion

        #region Adress
        public string Municipality { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string HouseNumberSuffix { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string countryCode { get; set; } = string.Empty;

        #endregion

        #region Contact
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? LinkedInUrl { get; set; } = string.Empty;
        public string? ContactOptions { get; set; } = string.Empty;
        #endregion

        #region Media
        public string ProfilePhotoRef { get; set; } = string.Empty;
        public string? PitchUrl { get; set; } = string.Empty;
        public string? LoopUrl { get; set; } = string.Empty;
        public string? CvUrl { get; set; } = string.Empty;
        #endregion

        public int? OrganisationId { get; set; }
        public BOOrganization? Organization { get; set; }

        public string JobTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        //public string CharacterTraits { get; set; } = string.Empty;

        public string Education { get; set; } = string.Empty;
        public int TravelDistance { get; set; }
        public string DesiredWorkLocation { get; set; } = string.Empty;
        public decimal AvailableHours { get; set; }
        public bool FoundJob { get; set; }
        public string WorksAtCompany { get; set; }
        public List<BOTalentPropertyMainCategory> TalentProperties { get; set; }
        public List<BOPastExperience> PastExperience {  get; set; }
        public List<BOHobby> Hobbies { get; set; }
        public List<BOEducationDetail> EducationDetails { get; set; }
        public bool IsProfileVisible { get; set; }


    }
}
