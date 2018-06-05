using JobsterV2.models.components;
using JobsterV2.models.strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.visitors
{
    public abstract class Visitor
    {
        protected Strategy strategy;

        public abstract void SetStrategy(Strategy aStrategy);
       
        public Strategy GetStrategy() { return strategy; }
        public void VisitANode(Component context)
        {
            strategy.Implement(context);
        }

    }
}
