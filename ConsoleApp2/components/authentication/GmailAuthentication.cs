using ConsoleApp2.models.data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Jobster.models.components.authentication;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Jobster.components.authentication
{
    public class GmailAuthentication:Authentication
    {


        public GmailAuthentication(int objectId) : base(Enums.ComponentNames.GmailAuthentication, objectId)
        {

        }

        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public override ReturnObject Authenticate()
        {
          return  _authenticator.Authenticate();
           
        }

       public override ReturnObject GetTypeOfLoginId()
        {
           return _authenticator.GetLoginTypeId();
        }
    }
}
