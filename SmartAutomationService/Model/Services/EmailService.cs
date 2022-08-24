using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using SmartAutomationService.Model.Data;

namespace SmartAutomationService.Model.Services
{
    public class EmailService
    {
        private readonly UtilService _utilService;

        public EmailService(UtilService utilService)
        {
            _utilService = utilService ?? throw new ArgumentNullException(nameof(utilService));
        }
        
        public void SendMail(SmartMail smartMail)
        {
            try
            {
                using var client = new SmtpClient();
                var mail = new MailMessage();
                client.Port = 587;
                client.Host = "smtp.office365.com";
                client.Timeout = 10000;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("mailer@carerx.ca", "genPCg~0NY,*9nf1Y9,SKyIZ^f/1v2~k");
                client.TargetName = "STARTTLS/smtp.office365.com";
                mail.IsBodyHtml = true;
                mail.From = new MailAddress("mailer@carerx.ca", smartMail.DisplayName);
                mail.Subject = smartMail.Subject;
                mail.Body = smartMail.Body;
                mail.Body += EmailFooter();
                smartMail.ReplyTo.ForEach(r =>
                {
                    if (!string.IsNullOrEmpty(r))
                    {
                        mail.ReplyToList.Add(r);
                    }
                });
                foreach (var email in smartMail.SendTo.Where(email => !string.IsNullOrEmpty(email)))
                {
                    mail.To.Add(new MailAddress(email));
                }

                if (smartMail.IsAttachment)
                {
                    foreach (var fullPath in smartMail.AttachmentList.Where(File.Exists))
                    {
                        mail.Attachments.Add(new Attachment(fullPath));
                    }
                }

                client.Send(mail);
                if (smartMail.IsAttachment)
                {
                    mail.Attachments.Dispose();
                }
            }
            catch (Exception e)
            {
                _utilService.WriteToLog(e.Source, e.Message, false);
                Console.WriteLine(e);
            }
        }

        private static string EmailFooter()
        {
            const string br = "<br>";
            var footer = br + br;
            footer += "Thank you" + br + br;
            footer += "CareRx Oakville" + br;
            footer += "Giving you Smart Options!" + br;
            footer += "3430 Superior Court" + br;
            footer += "Oakville, ON L6L 0C4" + br;
            footer += "Tel:  (833) 247-4316 ext 834" + br;
            footer += "Fax:  (866) 336-8509" + br + br;
            footer +=
                "<small><b>IMPORTANT NOTICE:</b> This message is intended only for the use of the individual or entity to which it is addressed. " +
                "The message may contain information that is privileged, confidential and exempt from disclosure under applicable law. " +
                "If the reader of this message is not the intended recipient, or the employee or agent responsible for delivering the message " +
                "to the intended recipient, you are notified that any dissemination, distribution or copying of this communication is strictly " +
                "prohibited. If you have received this communication in error, please notify CareRx immediately by email at privacy@smartmeds.ca. </small>";
            return footer;
        }
    }
}