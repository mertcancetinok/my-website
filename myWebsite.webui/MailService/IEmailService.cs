using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebsite.webui.MailService
{
    public interface IEmailService
    {
        public Task SendEmailAsync(string subject, string htmlContext);

    }
}
