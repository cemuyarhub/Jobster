using Jobster.models.components;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components
{
    public  class MailTemplateBox:Box
    {
        public MailTemplateBox(int objectId) : base(Enums.ComponentNames.MailTemplateBox, objectId)
        {

        }


    }
}
