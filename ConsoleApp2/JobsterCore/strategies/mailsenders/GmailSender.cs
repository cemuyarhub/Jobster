using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using JobsterV2.components;
using JobsterV2.components.navigation;
using JobsterV2.models.components;
using JobsterV2.models.strategies;
using System;
using System.IO;
using System.Net.Mail;
using System.Text;

namespace JobsterV2.mailsenders
{
   public class GmailSender:Strategy
    {

        static string ApplicationName = "Gmail API .NET Quickstart";
        private readonly string name = "Google";

        UserCredential credential;
      



        public  void DoFormatMail(Mail mail) {

            StringBuilder stringBuilder = new StringBuilder();
            AE.Net.Mail.MailMessage mailMessage = new AE.Net.Mail.MailMessage();

            AE.Net.Mail.Attachment asdf = new AE.Net.Mail.Attachment();
            
            //MailTemplate pull

            CompositeIterator iterator = (CompositeIterator)mail.CreateIterator();
            MailTemplate mailTemplate = (MailTemplate)iterator.First();


            //AttachmentBox pull
            iterator = (CompositeIterator)mailTemplate.CreateIterator();
            Attachments attachmentBox = (Attachments)iterator.First();

            //Attachments pull

            iterator = (CompositeIterator)attachmentBox.CreateIterator();

            while (!iterator.IsDone())
            {
                models.components.Attachment attachment =(models.components.Attachment)iterator.CurrentItem();
                mailMessage.Attachments.Add(new AE.Net.Mail.Attachment
                {
                    Body = attachment.GetFileDirectory()
                });
            }


            mailMessage.To.Add(new MailAddress(mail.TargetMail));
            mailMessage.Subject = mailTemplate.Subject;
            mailMessage.Body = mailTemplate.Body;
            var msgStr = new StringWriter();
            mailMessage.Save(msgStr);


            mail.FormatedMail = msgStr.ToString();
        

        }





        public  void DoSendMail(Mail mail)
        {

            try
            {

                // Create Gmail API service.
                var service = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                var newMsg = new Google.Apis.Gmail.v1.Data.Message
                {
                    Raw = Base64UrlEncode(mail.FormatedMail)

                };

                var result = service.Users.Messages.Send(newMsg, "me").Execute();
             

            }
            catch(Exception ex)
            {
          
            }


        }
        public static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }

        public override void Implement(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
