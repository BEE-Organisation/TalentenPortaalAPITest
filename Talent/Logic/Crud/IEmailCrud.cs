using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentLogic.Logic.BusinessObjects;

namespace TalentLogic.Logic.Crud
{
    public interface IEmailCrud
    {

        Task SendEmail(BOEmail email);

        Task SendEmailWithAttachment(BOEmail email, MemoryStream stream);

    }
}
