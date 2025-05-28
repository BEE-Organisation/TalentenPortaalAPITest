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
            bo.Name = model.Name;

            if(model.OrganisationId != null)
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
            bo.DateOfBirth = model.DateOfBirth.ToString("yyyy-MM-dd");
            bo.Education = model.Education;
            bo.Municipality = model.Municipality;
            bo.Province = model.Province;
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
            //From BO to entity
            Talent model = new Talent();

            if(bo.Id != null)
            {
                model.Id = bo.Id ?? 0;
            }

            model.Name = bo.Name;

            if(bo.OrganisationId != null)
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
            var dateOfBirth = DateOnly.FromDateTime(DateTime.ParseExact(bo.DateOfBirth, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));
            model.DateOfBirth = dateOfBirth;
//            model.DateOfBirth = DateOnly.FromDateTime(DateTime.Parse(bo.DateOfBirth));
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
