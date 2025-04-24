using Microsoft.AspNetCore.Mvc;
using TalentBackend.Validation;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.Crud;

namespace TalentBackend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmailController: ControllerBase
    {
        private readonly IEmailCrud _emailCrud;

        public EmailController(IEmailCrud emailCrud)
        {
            _emailCrud = emailCrud;
        }

        [HttpPost("SendEmail")]
        public async Task<IActionResult> SendEmail([FromBody] BOEmail email)
        {
            try
            {
                await _emailCrud.SendEmail(email);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [HttpPost("SendEmailWithAttachment")]
        public async Task<IActionResult> SendEmailWithAttachment([FromBody] BOEmail email)
        {
            try
            {
                if (email.Attachment == null)
                {
                    return BadRequest("Argument null");
                }

                if (email.Attachment.Length == 0)
                {
                    return BadRequest("File not selected");
                }

                if(!PdfValidator.IsCorrectPdf(email.Attachment))
                {
                    return BadRequest("File not PDF.");
                }

                int position = email.Attachment.IndexOf("base64,") + 7;
                string part = email.Attachment.Substring(position);
                byte[] bytes = System.Convert.FromBase64String(part);

                if (!PdfValidator.IsCorrectPdf(bytes))
                {
                    return BadRequest("File not PDF or too large!");
                }
                else
                {
                    MemoryStream file = new MemoryStream(bytes);

                    await _emailCrud.SendEmailWithAttachment(email, file);
                    return Ok();
                }                
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

    }
}
