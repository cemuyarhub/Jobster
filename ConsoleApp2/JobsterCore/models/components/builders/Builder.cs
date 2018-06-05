using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.components.builders
{
   public abstract class Builder
    {
        public abstract void BuildFirstInstance();

        public abstract Component GetResult();

    }
}
