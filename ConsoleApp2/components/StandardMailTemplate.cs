using Jobster.models.components;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components
{
    public class StandardMailTemplate : MailTemplate
    {
        public StandardMailTemplate( int objectId) : base(Enums.ComponentNames.StandardMailTemplate, objectId)
        {
        }


    }
}
