using Jobster.models.components;
using Jobster.models.components.implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components.implementations
{
  public  class ComponentRemover : ComponentOperator
    {
        public override void Operate(Component c)
        {
            Component ancestor=c.GetAncestor();
            ancestor.Remove(c, c.ObjectId);
            c = ancestor;

        }
    }
}
