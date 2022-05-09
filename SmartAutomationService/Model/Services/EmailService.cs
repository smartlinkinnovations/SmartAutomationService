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
                client.Port = 25;
                client.Host = "sm-svr207.smartmeds.ca";
                client.Timeout = 10000;
                client.EnableSsl = false;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("notification@smartmeds.ca", "");
                mail.IsBodyHtml = true;
                mail.From = new MailAddress("notification@smartmeds.ca", smartMail.DisplayName);
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
            footer += "SmartMeds Pharmacy" + br;
            footer += "Giving you Smart Options!" + br;
            footer += "1252 Northside Road" + br;
            footer += "Burlington, ON L7M 1H6" + br;
            footer += "Tel:  (905) 336-8672" + br;
            footer += "Cell: (905) 599-0663" + br;
            footer += "Fax:  (905) 336-8509" + br + br;
            footer +=
                "<small><b>IMPORTANT NOTICE:</b> This message is intended only for the use of the individual or entity to which it is addressed. " +
                "The message may contain information that is privileged, confidential and exempt from disclosure under applicable law. " +
                "If the reader of this message is not the intended recipient, or the employee or agent responsible for delivering the message " +
                "to the intended recipient, you are notified that any dissemination, distribution or copying of this communication is strictly " +
                "prohibited. If you have received this communication in error, please notify SmartMeds immediately by email at privacy@smartmeds.ca. </small>";
            return footer;
        }
    }
}