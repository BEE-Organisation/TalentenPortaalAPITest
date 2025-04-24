using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.Repositories;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.Email;

namespace TalentLogic.Logic.Crud
{
    public class EmailCrud : IEmailCrud
    {
        private readonly IVacancyCompleteRepository _vacancyCompleteRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IMailKitService _mailKitService;

        public EmailCrud(
            IVacancyCompleteRepository vacancyCompleteRepository,
            ICompanyRepository companyRepository,
            IMailKitService mailKitService
        )
        {
            _vacancyCompleteRepository = vacancyCompleteRepository;
            _companyRepository = companyRepository;
            _mailKitService = mailKitService;
        }

        public async Task SendEmail(BOEmail email)
        {
            var company = await _companyRepository.GetById(email.TargetCompanyId);

            if(company == null)
            {
                throw new Exception("Something went wrong");
            }

            var vacancy = await _vacancyCompleteRepository.GetById(email.VacancyId);

            if(vacancy == null)
            {
                throw new Exception("Something went wrong");
            }

            string subject = RemoveHTML(email.Subject).ToLower();
            string body = PrepareBody(email);

            //Testing purposes.
            //string emailTo = "your-email@outlook.com";

            try
            {
                await _mailKitService.SendEmailAsync(company.Email, subject + vacancy.Title, body);
                //Testing purposes.
                //await _mailKitService.SendEmailAsync(emailTo, subject + " " + vacancy.Title, body);
            }
            catch
            {
                throw new Exception("Something went wrong.");
            }            
        }


        public async Task SendEmailWithAttachment(BOEmail email, MemoryStream stream)
        {
            var company = await _companyRepository.GetById(email.TargetCompanyId);

            if (company == null)
            {
                throw new Exception("Something went wrong");
            }

            var vacancy = await _vacancyCompleteRepository.GetById(email.VacancyId);

            if (vacancy == null)
            {
                throw new Exception("Something went wrong");
            }

            string subject = RemoveHTML(email.Subject).ToLower();
            string body = PrepareBody(email);

            //Testing purposes.
            //string emailTo = "your-email@outlook.com";

            try
            {
                await _mailKitService.SendEmailAsync(company.Email, subject + vacancy.Title, body);
                //await _mailKitService.SendEmailAsyncAttachment(emailTo, subject + " " + vacancy.Title, body, stream);
            }
            catch
            {
                throw new Exception("Something went wrong.");
            }
        }

        private string RemoveHTML(string item)
        {
            return Regex.Replace(item, "<.*?>", String.Empty);
        }

        private string PrepareBody(BOEmail email)
        {
            string s = "<html><body>";
            s += "Naam: " + RemoveHTML(email.Name) + "<br>";
            s += "Email: " + RemoveHTML(email.Email) + "<br>";
            s += "Telefoonnummer: " + RemoveHTML(email.PhoneNumber) + "<br>";
            s += "Bericht: " + RemoveHTML(email.Text) + "<br>";
            s += "</body></html>";

            return s;
        }

    }
}
