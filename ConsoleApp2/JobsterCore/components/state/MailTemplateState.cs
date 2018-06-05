using JobsterV2.models.components.state;
using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components.state
{
    public class MailTemplateState : State
    {
          public override Enums.ComponentNames GetEqualiventComponentName()
        {
            return Enums.ComponentNames.MailTemplateBox;

        }
    }
}
