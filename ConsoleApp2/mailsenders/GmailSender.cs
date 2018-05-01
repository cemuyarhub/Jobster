using ConsoleApp2.data.operators;
using ConsoleApp2.models.authentication;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Jobster.components;
using Jobster.components.navigation;
using Jobster.data;
using Jobster.models.components;
using Jobster.models.data;
using Jobster.models.enums;
using Jobster.models.mailsenders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Threading;

namespace Jobster.mailsenders
{
   public class GmailSender:MailSender
    {

        static string ApplicationName = "Gmail API .NET Quickstart";
        private readonly string name = "Google";

        UserCredential credential;
      



        public override  string DoFormatMail(Mail mail) {

            StringBuilder stringBuilder = new StringBuilder();
            AE.Net.Mail.MailMessage mailMessage = new AE.Net.Mail.MailMessage();

            AE.Net.Mail.Attachment asdf = new AE.Net.Mail.Attachment();
            
            //MailTemplate pull

            CompositeIterator iterator = (CompositeIterator)mail.CreateIterator();
            MailTemplate mailTemplate = (MailTemplate)iterator.First();


            //AttachmentBox pull
            iterator = (CompositeIterator)mailTemplate.CreateIterator();
            AttachmentBox attachmentBox = (AttachmentBox)iterator.First();

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


        

            return null;
        }





        public override ReturnObject DoSendMail(Mail mail)
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

                return new StandardReturnObject()
                {
                    Result = Enums.DataReturnType.Success                    
                };

            }
            catch(Exception ex)
            {
                return new StandardReturnObject()
                {
                    Result = Enums.DataReturnType.Failure,
                    Message = ex.Message
                };
            }


        }
        public static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }

        public override ReturnObject GetMailType() {

            return TypesOfLoginOperator.GetIdFromType(name);

        }

    }
}
