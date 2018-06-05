using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.components.observers
{

    public abstract  class ComponentIndexer
    {
        public abstract int? GetObjectId(Object identifier);
        public abstract void Add(Component component);
        public abstract void Remove(Component component);


    }
}
