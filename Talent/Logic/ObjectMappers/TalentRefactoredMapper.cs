using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.ObjectMappers
{
    public class TalentRefactoredMapper
    {

        public static BOTalentRefactored Map(Talent model)
        {
            //From entity to BO
            BOTalentRefactored bo = new BOTalentRefactored();

            bo.Id = model.Id;

            #region Personal Information

            bo.Name = model.Name;
            bo.Initials = model.Initials;
            bo.GivenName = model.GivenName; 
            bo.Surname = model.Surname; 
            bo.NamePrefix = model.NamePrefix;
            bo.DateOfBirth = model.DateOfBirth.ToString("dd-MM-yyyy");

            #endregion

            #region Adress

            bo.Municipality = model.Municipality;
            bo.Province = model.Province;
            bo.Street = model.Street; 
            bo.HouseNumber = model.HouseNumber; 
            bo.HouseNumberSuffix = model.HouseNumberSuffix; 
            bo.PostalCode = model.PostalCode; 
            bo.countryCode = model.CountryCode; 

            #endregion

            #region Contact
            
            bo.Email = model.Email; 
            bo.PhoneNumber = model.PhoneNumber;
            bo.LinkedInUrl = model.LinkedInUrl;
            bo.ContactOptions = model.ContactOptions;

            #endregion

            #region Media

            bo.ProfilePhotoRef = model.ProfilePhotoRef;
            if (!model.PitchUrl.Equals("") && !model.PitchUrl.Equals("null"))
            {
                bo.PitchUrl = model.PitchUrl;
            }
            if (!model.LoopUrl.Equals("") && !model.LoopUrl.Equals("null"))
            {
                bo.LoopUrl = model.LoopUrl;
            }
            bo.CvUrl = model.CvUrl;

            #endregion

            if (model.OrganisationId != null)
            {
                bo.OrganisationId = model.OrganisationId;
            }
            if (model.Organization != null)
            {
                bo.Organization = OrganizationMapper.Map(model.Organization);
            }

            bo.JobTitle = model.JobTitle;
            bo.Description  = model.Description;
            //bo.CharacterTraits = model.CharacterTraits;
            bo.Education = model.Education;
            bo.TravelDistance = model.TravelDistance;
            bo.DesiredWorkLocation = model.DesiredWorkLocation;
            bo.AvailableHours = model.AvailableHours;            
            bo.FoundJob = model.FoundJob;
            bo.WorksAtCompany = model.WorksAtCompany;
            bo.IsProfileVisible = model.IsProfileVisible;

            return bo;
        }

        public static Talent Map(BOTalentRefactored bo)
        {
            //From BO to entity
            Talent model = new Talent();

            if(bo.Id != null)
            {
                model.Id = bo.Id ?? 0;
            }

            #region Personal Information

            model.Name = bo.Name;
            model.Initials = bo.Initials;
            model.GivenName = bo.GivenName;
            model.Surname = bo.Surname;
            model.NamePrefix = bo.NamePrefix;
//            model.DateOfBirth = DateTime.Parse(bo.DateOfBirth);

            #endregion

            #region Adress

            model.Municipality = bo.Municipality;
            model.Province = bo.Province;
            model.Street = bo.Street;
            model.HouseNumber = bo.HouseNumber;
            model.HouseNumberSuffix = bo.HouseNumberSuffix;
            model.PostalCode = bo.PostalCode;
            model.CountryCode = bo.countryCode;

            #endregion

            #region Contact

            model.Email = bo.Email;
            model.PhoneNumber = bo.PhoneNumber;
            model.LinkedInUrl = bo.LinkedInUrl;
            model.ContactOptions = bo.ContactOptions;

            #endregion

            #region Media

            model.ProfilePhotoRef = bo.ProfilePhotoRef;
            model.PitchUrl = bo.PitchUrl;
            model.LoopUrl = bo.LoopUrl;

            if (!bo.CvUrl.Equals(""))
            {
                model.CvUrl = bo.CvUrl;
            }

            #endregion

            if (bo.OrganisationId != null)
            {
                model.OrganisationId = (bo.OrganisationId > 0) ? bo.OrganisationId : null;
            }
            else
            {
                model.OrganisationId = null;
            }

            if (bo.Organization != null)
            {                
                model.Organization = OrganizationMapper.Map(bo.Organization);
            }

            model.JobTitle = bo.JobTitle;
            model.Description = bo.Description;
//            model.DateOfBirth = DateOnly.Parse(bo.DateOfBirth);
            var dateOfBirth = DateOnly.FromDateTime(DateTime.ParseExact(bo.DateOfBirth, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture));
            model.DateOfBirth = dateOfBirth;
//            model.DateOfBirth = DateOnly.FromDateTime(DateTime.Parse(bo.DateOfBirth));
            model.Education = bo.Education;
            model.TravelDistance = bo.TravelDistance;
            model.DesiredWorkLocation = bo.DesiredWorkLocation;
            model.AvailableHours = bo.AvailableHours;
            model.FoundJob = bo.FoundJob;
            model.WorksAtCompany = bo.WorksAtCompany;
            model.IsProfileVisible = bo.IsProfileVisible;    

            return model;
        }

    }

}
