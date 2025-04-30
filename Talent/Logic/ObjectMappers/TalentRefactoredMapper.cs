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
            // TODO: Add properties to Talent when they are added to DataAccessObjects

            BOTalentRefactored bo = new BOTalentRefactored();

            bo.Id = model.Id;
            bo.Initials = "P.J."; // model.Initials;
            bo.GivenName = "Peter"; // model.GivenName; 
            bo.NamePrefix = "de"; // model.NamePrefix;
            bo.LastName = "Waal"; // model.LastName; 
            bo.Name = model.Name;
            bo.PhoneNumber = "06 12345678"; // model.PhoneNumber;
            bo.EmailAddress = "pdwaal@gmail.com"; // model.EmailAddress; 
            bo.StreetName = "Hoofdstraat"; // model.StreetName; 
            bo.HouseNumber = "7"; // model.HouseNumber; 
            bo.HouseNumberSuffix = "A"; // model.HouseNumberSuffix; 
            bo.PostalCode = "1234 AB"; // model.PostalCode; 
            bo.Municipality = model.Municipality;   
            bo.Province = model.Province;
            bo.countryCode = "NL"; // model.countryCode; 

            if (model.OrganisationId != null)
            {
                bo.OrganisationId = model.OrganisationId;
            }

            if(model.Organization != null)
            {
                bo.Organization = OrganizationMapper.Map(model.Organization);
            }
            
            bo.JobTitle = model.JobTitle;
            bo.Description  = model.Description;
            //bo.CharacterTraits = model.CharacterTraits;
            bo.DateOfBirth = model.DateOfBirth.ToString();
            bo.Education = model.Education;
            bo.ProfilePhotoRef = model.ProfilePhotoRef;
            bo.LinkedInUrl = model.LinkedInUrl;
            bo.ContactOptions = model.ContactOptions;

            if(!model.PitchUrl.Equals("") && !model.PitchUrl.Equals("null"))
            {
                bo.PitchUrl = model.PitchUrl;
            }

            if (!model.LoopUrl.Equals("") && !model.LoopUrl.Equals("null"))
            {
                bo.LoopUrl = model.LoopUrl;
            }

            bo.CvUrl = model.CvUrl;

            bo.TravelDistance = model.TravelDistance;
            bo.DesiredWorkLocation = model.DesiredWorkLocation;
            bo.AvailableHours = model.AvailableHours;
            bo.IsProfileVisible = model.IsProfileVisible;
            bo.FoundJob = model.FoundJob;
            bo.WorksAtCompany = model.WorksAtCompany;

            return bo;
        }

        public static Talent Map(BOTalentRefactored bo)
        {
            Talent model = new Talent();

            if(bo.Id != null)
            {
                model.Id = bo.Id ?? 0;
            }

            model.Name = bo.Name;

            // TODO: Add properties to Talent when they are added to DataAccessObjects

            //model.Id = bo.Id;
            //model.Initials = bo.Initials;
            //model.GivenName = bo.GivenName; 
            //model.NamePrefix = bo.NamePrefix;
            //model.LastName = bo.LastName; 
            //model.Name = bo.Name;
            //model.PhoneNumber = bo.PhoneNumber;
            //model.EmailAddress = bo.EmailAddress; 
            //model.StreetName = bo.StreetName; 
            //model.HouseNumber = bo.HouseNumber; 
            //model.HouseNumberSuffix = bo.HouseNumberSuffix; 
            //model.PostalCode = bo.PostalCode; 
            //model.Municipality = bo.Municipality;
            //model.Province = bo.Province;
            //model.countryCode = bo.countryCode; 

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
            model.DateOfBirth = DateTime.Parse(bo.DateOfBirth);
            model.Education = bo.Education;
            model.Municipality = bo.Municipality;
            model.Province = bo.Province;
            model.ProfilePhotoRef = bo.ProfilePhotoRef;
            model.PitchUrl = bo.PitchUrl;
            model.LoopUrl = bo.LoopUrl;

            if(!bo.CvUrl.Equals(""))
            {
                model.CvUrl = bo.CvUrl;
            }

            model.LinkedInUrl = bo.LinkedInUrl;
            model.ContactOptions = bo.ContactOptions;
            model.TravelDistance = bo.TravelDistance;
            model.DesiredWorkLocation = bo.DesiredWorkLocation;
            model.AvailableHours = bo.AvailableHours;
            model.IsProfileVisible = bo.IsProfileVisible;
            model.FoundJob = bo.FoundJob;
            model.WorksAtCompany = bo.WorksAtCompany;

            return model;
        }

    }

}
