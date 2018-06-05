using System;
using System.Collections.Generic;
using System.Text;
using JobsterV2.models.components.observers;
using JobsterV2.models.enums;

namespace JobsterV2.models.components
{
    public abstract class RootController : CompositeComponent
    {
        public RootController(Enums.ComponentNames name, int objectId) : base(name, objectId)
        {
        }

     
    }
}
