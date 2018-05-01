using Jobster.models.components.state;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components.state
{
    public class SentState : State
    {
        public override Enums.ComponentNames GetEqualiventComponentName()
        {
            return Enums.ComponentNames.SentBox;
        }
    }
}
