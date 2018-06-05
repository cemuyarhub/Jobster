using ConsoleApp2.models.data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using JobsterV2.models.components.authentication;
using JobsterV2.models.enums;
using JobsterV2.models.visitors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace JobsterV2.components.authentication
{
    public class GmailAuthentication:Authentication
    {


        public GmailAuthentication(int objectId) : base(Enums.ComponentNames.GmailAuthentication, objectId)
        {

        }

        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public override void Visit(Visitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
