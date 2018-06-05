using JobsterV2.models.components.builders;
using JobsterV2.models.components.observers;
using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.components.directors
{
   public abstract class Director
    {
             public abstract void Construct(ComponentBuilder builder);
    }
}
