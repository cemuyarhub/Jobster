using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.components.state
{
   public interface IStateable
    {
        State State { get; set; }
        void ChangeState(Enums.StateTypes type);

    }
}
