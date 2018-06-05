using JobsterV2.models.components;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.strategies
{
    public abstract class Strategy
    {
        public abstract void Implement(Component component);

    }
}
