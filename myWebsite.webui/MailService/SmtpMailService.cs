using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace myWebsite.webui.MailService
{
    public class SmtpMailService : IEmailService
    {
        private string _host;
        private int _port;
        private string _username;
        private string _password;
        private bool _enableSSL;
        public SmtpMailService(string host,int port,string username,string password,bool enableSSL)
        {
            this._host = host;
            this._port = port;
            this._username = username;
            this._password = password;
            this._enableSSL = enableSSL;
        }
        public Task SendEmailAsync(string subject, string htmlContext)
        {
            var client = new SmtpClient(this._host, this._port)
            {
                Credentials = new NetworkCredential(_username,_password),
                EnableSsl = this._enableSSL
            };

            return client.SendMailAsync(new MailMessage(_username, _username, subject, htmlContext)
            {
                IsBodyHtml=true
            });



        }
    }
}
