using ConsoleApp2.models.authenticators;
using ConsoleApp2.models.data;
using Jobster.models.components.authentication;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components.authentication
{
    class MicrosoftAuthentication : Authentication
    {
        public MicrosoftAuthentication(int objectId) : base(Enums.ComponentNames.MicrosoftAuthentication, objectId)
        {

        }

        public override ReturnObject Authenticate()
        {
            throw new NotImplementedException();
        }

  
        public override ReturnObject GetTypeOfLoginId()
        {
            throw new NotImplementedException();
        }
    }
}
