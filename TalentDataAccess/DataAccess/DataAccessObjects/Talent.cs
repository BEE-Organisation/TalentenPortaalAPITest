using CrossCuttingConcerns.EntityFrameworkGenerics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{

    [Table("Talent", Schema = "TalentenPortaal")]
    public class Talent: IEntity
    {
        [Key]
        public int Id { get; set; }

        #region Personal Information
        [Required]
        public string Name { get; set; } = string.Empty; // TODO: remove when possible, used in CreateTalentNewData 
        [Required]
        public string Initials { get; set; } = string.Empty; 
        [Required]
        public string GivenName { get; set; } = string.Empty;
        [Required]
        public string Surname { get; set; } = string.Empty;
        public string NamePrefix { get; set; } = string.Empty;
        [Required]
        public DateOnly DateOfBirth { get; set; }
        #endregion

        #region Adress
        [Required]
        public string Municipality { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string HouseNumberSuffix { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        #endregion

        #region Contact
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string LinkedInUrl { get; set; } = string.Empty;
        public string ContactOptions { get; set; } = string.Empty;
        #endregion

        #region Media
        public string ProfilePhotoRef { get; set; } = string.Empty;
        public string PitchUrl { get; set; } = string.Empty;
        public string LoopUrl { get; set; } = string.Empty;
        //CVUrl = added for Bee-Organisation.
        public string CvUrl { get; set; } = string.Empty;
        #endregion

        [ForeignKey("Organization")]
        public int? OrganisationId { get; set; }
        public Organization? Organization { get; set; }

        [Required]
        public string JobTitle { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        //Karakterschets => to Properties.
        //[Required]
        //public string CharacterTraits { get; set; } = string.Empty;
//        public DateOnly DateOfBirth { get; set; }

        //Education as Denkniveau
        public string Education { get; set; } = string.Empty;
               
        public int TravelDistance { get; set; } = 0;
        public string DesiredWorkLocation {  get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AvailableHours { get; set; }

        public bool FoundJob { get; set; } = false;

        public string WorksAtCompany { get; set; } = string.Empty;

        //public List<PropertyOptionSelection>? PropertyOptionSelection { get; set; }

        //Below: TalentPropertyMainCategoryLink
        //
        //See the classes: 1) TalentPropertyMainCategoryLink, 2) TalentPropertySubCategoryLink and 3) TalentPropertyLabel
        //
        //Where the table 1) TalentPropertyMainCategoryLink contains the Parent/Main-Category. e.g.: Languages
        //
        //Where the table 2) TalentPropertySubCategoryLink contains the Children/sub-categories. e.g.: Dutch, English, German, French, etc.
        //
        //Where the table 3) TalentPropertyLabel constains all Parent- and Children labels. This table also prevents duplicates.

        public ICollection<TalentPropertyMainCategoryLink>? TalentPropertyMainCategoryLinks { get; set; }

        public ICollection<PastExperience>? PastExperiences { get; set; }
        public ICollection<EducationDetail>? EducationDetails { get; set; }
        public bool IsProfileVisible { get; set; }
    }
    /*
    //  Default setup
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // These are all the pre-defined property options available
        public List<PropertyOption>? DefaultPropertyOptions { get; set; }

    }

    public class PropertyOption
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [ForeignKey("Property")]
        public int PropertyId { get; set; }

        public required Property Property { get; set; }
    }
    // End default setup

    public class PropertyOptionSelection
    {
        public int Id { get; set; }
        public int TalentId { get; set; }
        public int PropertyId { get; set; }
        // No OptionId => this means this is a custom property option
        public int? OptionId { get; set; }
        // No CustomName => this means this is a default property option
        public string? CustomName { get; set; }
        public int SkillLevel { get; set; }
    }
    */
}
