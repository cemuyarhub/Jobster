using System;
using System.Collections.Generic;
using System.Text;
using Jobster.models.enums;

namespace Jobster.models.components
{
    public abstract class RootController : CompositeComponent
    {
        public RootController(Enums.ComponentNames name, int objectId) : base(name, objectId)
        {
        }
    }
}
