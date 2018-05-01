using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.models.components.observers
{

    public abstract  class ComponentIndexer:Observer
    {

        public abstract int? GetObjectId(enums.Enums.ComponentNames name);


    }
}
