using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using JobsterV2.components.authentication;
using JobsterV2.models.components;
using JobsterV2.models.components.authentication;
using JobsterV2.models.data;
using JobsterV2.models.strategies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace JobsterV2.strategies.authentication
{
    public class GmailAuthenticationImp : Strategy
    {


        private readonly string _name = "Google";

        private int typeOfLoginId;

        private UserCredential credential;

        static string[] Scopes = { GmailService.Scope.GmailSend };
        public void Authenticate(Authentication modifier)
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



                GmailAuthentication gModifier = (GmailAuthentication)modifier;

                gModifier.AccessToken = credential.Token.AccessToken;
                gModifier.RefreshToken = credential.Token.RefreshToken;
                gModifier.LastUpdateTime = DateTime.Now;
           }


        }

        public override void Implement(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
