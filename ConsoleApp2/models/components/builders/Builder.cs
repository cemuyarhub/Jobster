using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.models.components.builders
{
  public abstract class Builder

    {
        public abstract void BuildNewComponent(Enums.ComponentNames componentName);
        public abstract void SetNewObjectId(int newObjectId);
        public abstract Component GetResult();
    }
}
