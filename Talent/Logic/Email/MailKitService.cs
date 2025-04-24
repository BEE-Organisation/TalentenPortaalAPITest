using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit.Text;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using System.Net;
using System.IO;
using System.Net.Mime;

namespace TalentLogic.Logic.Email
{

    public class MailKitEmailSenderOptions
    {
        public MailKitEmailSenderOptions()
        {
            HostSecureSocketOptions = SecureSocketOptions.Auto;
        }

        public string HostAddress { get; set; }

        public int HostPort { get; set; }

        public string HostUsername { get; set; }

        public string HostPassword { get; set; }

        public SecureSocketOptions HostSecureSocketOptions { get; set; }

        public string SenderEMail { get; set; }

        public string SenderName { get; set; }
    }

    public interface IMailKitService
    {
        MailKitEmailSenderOptions Options { get; set; }
        Task SendEmailAsync(string email, string subject, string message);

        Task SendEmailAsyncAttachment(string email, string subject, string message, MemoryStream stream);
        Task Execute(string to, string subject, string message);

        Task ExecuteAttachment(string to, string subject, string message, MemoryStream stream);
    }

    public class MailKitService : IMailKitService
    {

        public MailKitEmailSenderOptions Options { get; set; }

        public MailKitService(IOptions<MailKitEmailSenderOptions> options)
        {
            this.Options = options.Value;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(email, subject, message);
        }

        public Task SendEmailAsyncAttachment(string email, string subject, string message, MemoryStream stream)
        {
            return ExecuteAttachment(email, subject, message, stream);
        }

        public Task Execute(string to, string subject, string message)
        {
            try
            {
                // create message
                var email = new MimeMessage
                {
                    Sender = MailboxAddress.Parse(Options.SenderEMail)
                };
                if (!string.IsNullOrEmpty(Options.SenderName))
                {
                    email.Sender.Name = Options.SenderName;
                }
                email.From.Add(email.Sender);
                email.To.Add(MailboxAddress.Parse(to));
                email.Subject = subject;
                email.Body = new TextPart(TextFormat.Html) { Text = message };

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // send email
                using (var smtp = new SmtpClient())
                {
                    smtp.CheckCertificateRevocation = false;
                    smtp.Connect(Options.HostAddress, Options.HostPort, Options.HostSecureSocketOptions);                    
                    smtp.Authenticate(Options.HostUsername, Options.HostPassword);
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }

                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task ExecuteAttachment(string to, string subject, string message, MemoryStream stream)
        {
            try
            {
                // create message
                var email = new MimeMessage
                {
                    Sender = MailboxAddress.Parse(Options.SenderEMail)
                };
                if (!string.IsNullOrEmpty(Options.SenderName))
                {
                    email.Sender.Name = Options.SenderName;
                }
                email.From.Add(email.Sender);
                email.To.Add(MailboxAddress.Parse(to));
                email.Subject = subject;
                //email.Body = new TextPart(TextFormat.Html) { Text = message };

                var multipart = new Multipart("mixed");
                var textPart = new TextPart(TextFormat.Html)
                {
                    Text = message,
                    ContentTransferEncoding = ContentEncoding.Base64,
                };
                multipart.Add(textPart);

                stream.Position = 0;

                var attachmentPart = new MimePart(MediaTypeNames.Application.Pdf)
                {
                    Content = new MimeContent(stream),
                    ContentId = "cv.pdf",
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = "cv.pdf",
                };
                multipart.Add(attachmentPart);

                email.Body = multipart;

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // send email
                using (var smtp = new SmtpClient())
                {
                    smtp.CheckCertificateRevocation = false;
                    smtp.Connect(Options.HostAddress, Options.HostPort, Options.HostSecureSocketOptions);
                    smtp.Authenticate(Options.HostUsername, Options.HostPassword);
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }

                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
