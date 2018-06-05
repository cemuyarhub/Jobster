using ConsoleApp2.models.data;
using JobsterV2.models.components.authentication;
using JobsterV2.models.enums;
using JobsterV2.models.visitors;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components.authentication
{
    class MicrosoftAuthentication : Authentication
    {
        public MicrosoftAuthentication(int objectId) : base(Enums.ComponentNames.MicrosoftAuthentication, objectId)
        {

        }

        public override void Visit(Visitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
