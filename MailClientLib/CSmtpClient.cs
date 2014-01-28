using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClientLib
{
    public class CSmtpClient
    {
        #region / locals /
        private MailAddress objMailTo, objMailFrom;
        private MailMessage objMail;
        private string usr, pass;
        #endregion
        #region / properties /
        public string mailTo { get; set; }
        public string mailFrom { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        #endregion
        #region / constructor /
        public CSmtpClient(string usr, string pass, string mailTo, string mailFrom, string subject, string message)
        {
            this.mailTo = mailTo;
            this.mailFrom = mailFrom;
            this.subject = subject;
            this.message = message;

            objMailTo = new MailAddress(mailTo);
            objMailFrom = new MailAddress(mailFrom);
            objMail = new MailMessage(objMailFrom, objMailTo);
            objMail.Subject = subject;
            objMail.Body = message;
            this.usr = usr;
            this.pass = pass;
        }
        public CSmtpClient(string usr, string pass, string mailTo, string mailFrom, string subject, string message, Attachment attachment)
        {
            this.mailTo = mailTo;
            this.mailFrom = mailFrom;
            this.subject = subject;
            this.message = message;

            objMailTo = new MailAddress(mailTo);
            objMailFrom = new MailAddress(mailFrom);
            objMail = new MailMessage(objMailFrom, objMailTo);
            objMail.Subject = subject;
            objMail.Body = message;
            objMail.Attachments.Add(attachment);
            this.usr = usr;
            this.pass = pass;
        } 
        #endregion
        #region / public /
        public void sendMessage()
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(usr, pass);
            smtp.EnableSsl = true;
            smtp.Send(objMail);

            smtp.Dispose();
        }
        #endregion
    }
}
