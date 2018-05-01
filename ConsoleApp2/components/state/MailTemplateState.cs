using Jobster.models.components.state;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components.state
{
    public class MailTemplateState : State
    {
          public override Enums.ComponentNames GetEqualiventComponentName()
        {
            return Enums.ComponentNames.MailTemplateBox;

        }
    }
}
