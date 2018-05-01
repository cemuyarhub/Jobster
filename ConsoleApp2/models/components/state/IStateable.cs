using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.models.components.state
{
   public interface IStateable
    {
        State State { get; set; }
        void ChangeState(Enums.StateTypes type);

    }
}
