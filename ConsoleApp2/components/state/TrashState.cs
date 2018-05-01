using Jobster.models.components;
using Jobster.models.components.state;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components.state
{
    public class TrashState : State
    {
        public override Enums.ComponentNames GetEqualiventComponentName()
        {
            return Enums.ComponentNames.TrashBox;
        }
    }
}

