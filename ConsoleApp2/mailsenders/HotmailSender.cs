using ConsoleApp2.data.operators;
using ConsoleApp2.models.authentication;
using ConsoleApp2.models.data;
using ConsoleApp2.models.mailsenders;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace ConsoleApp2.mailsenders
{
    public  class HotmailSender:MailSenderBase
    {
        static string[] Scopes = { GmailService.Scope.GmailSend };
        static string ApplicationName = "Gmail API .NET Quickstart";
        private readonly string name = "Microsoft";

        UserCredential credential;
        public AuthGoogle Authentication()
        {

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }


            return null;

        }



        public override Message CreateAMail() {

            string plainText = "To: korhantuncer216@hotmail.com\r\n" +
                         "Subject: subject Test\r\n" +
                         "Content-Type: text/html; charset=us-ascii\r\n\r\n" +
                         "<h1>Body Test </h1>";

            var newMsg = new Google.Apis.Gmail.v1.Data.Message
            {
                Raw = Base64UrlEncode(plainText.ToString())
            };

            return null;
        }


        public override Boolean SendAMail()
        {
           


            // Create Gmail API service.
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            var newMsg = CreateAMail();
            service.Users.Messages.Send(newMsg, "me").Execute();
            return false;
        }
        public static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }

        public override ReturnObject GetMailType()
        {

            return TypesOfLoginOperator.GetIdFromType(name);

        }


    }
}
