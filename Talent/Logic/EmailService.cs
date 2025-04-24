using System.Collections.Generic;
using System.Threading.Tasks;
using CrossCuttingConcerns;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic
{
    public interface IEmailService
    {
        Task<bool> SendEmailMessage(BOContactEmail boContactEmail);
    }

    public class EmailService : IEmailService
    {
        private AppSettings AppSettings { get; set; }
        public EmailService(
            IOptions<AppSettings> settings)
        {
            AppSettings = settings.Value;
        }


        public async Task<bool> SendEmailMessage(BOContactEmail boContactEmail)
        {

            var client = new SendGridClient(AppSettings.SendGridApiKey);
            var from = new EmailAddress("info@bee-ideas.com", "CV App");
            var tos = new List<EmailAddress>
            {
                new EmailAddress("info@bee-ideas.com","Beste cv-app admin"),
                new EmailAddress("info@bee-inclusive.com","Beste cv-app admin")
            };

            const string subject = "Contact gezocht via CV-App";

            var htmlContent = TextEmail(boContactEmail);

            var msg = new SendGridMessage();

            msg.SetFrom(from);

            msg.SetGlobalSubject(subject);


            if (!string.IsNullOrEmpty(htmlContent))
            {
                msg.AddContent(MimeType.Html, htmlContent);
            }

            msg.AddTos(tos);

            Response response = await client.SendEmailAsync(msg).ConfigureAwait(false);

            return true;
        }

        private string TextEmail(BOContactEmail boContactEmail)
        {
            var htmlContent = "<h3>Contact via CV App</h3>";
            htmlContent += $"Naam: {boContactEmail.Name}<br>";
            htmlContent += $"Bedrijf: {boContactEmail.Company}<br>";
            htmlContent += $"Email: {boContactEmail.Email}<br>";
            htmlContent += $"Telefoon nr.: {boContactEmail.Phone}<br>";
            htmlContent += $"Onderwerp: {boContactEmail.EmailReason}<br>";
            htmlContent += $"Extra info: {boContactEmail.Text}<br>";
            return htmlContent;
        }
    }
}
