using ConsoleApp2.models.authenticators.imp;
using ConsoleApp2.models.data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace ConsoleApp2.authenticators.imp
{
    public class GmailAuthenticationImp : AuthenticationImplementor
    {


        private readonly string _name = "Google";

        private int typeOfLoginId;

        private UserCredential credential;

        static string[] Scopes = { GmailService.Scope.GmailSend };
        public override ReturnObject Authenticate()
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
                    CancellationToken.None, null).Result;
            }

            if (credential != null)
            {
                auth = new Authentication()
                {
                    RefreshToken = credential.Token.RefreshToken,
                    AccessToken = credential.Token.AccessToken,
                    LastUpdateTime = DateTime.Now


                };
            }


            return auth;
        }

        public override ReturnObject GetLoginTypeId()
        {
            throw new NotImplementedException();
        }
    }
}
