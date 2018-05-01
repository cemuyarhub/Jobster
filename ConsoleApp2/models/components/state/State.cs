using Jobster.components.state;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.models.components.state
{
  public abstract  class State
    {

        public void ChangeState(IStateable stateable, Enums.StateTypes type)
        {
            switch (type)
            {
                case Enums.StateTypes.Draft://do nothing
                    break;
                case Enums.StateTypes.Trash:
                    stateable.State = new TrashState();
                    break;
                case Enums.StateTypes.Sent:
                    stateable.State = new SentState();
                    break;
                case Enums.StateTypes.MailTemplate:
                    stateable.State = new MailTemplateState();
                    break;
                default:
                    break;
            }

        }
        public abstract Enums.ComponentNames GetEqualiventComponentName();


    }
}
