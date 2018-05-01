using ConsoleApp2.models;
using Jobster.models.components;
using Jobster.models.components.implementations;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components.implementors
{
    public class PrimitiveImplementor : ComponentImplementor
    {
        public override void DoAccept()
        {
            throw new NotImplementedException();
        }

        public override void DoAdd(Component c, int objectId, Component modifier)
        {
            throw new NotImplementedException();
        }

        public override Component DoFindRoot(Component modifier)
        {
            return modifier.GetAncestor().FindRoot();
        }

        public override Component DoGet(int objectId, Component modifier)
        {
            throw new NotImplementedException();
        }

        public override void DoModify(Component c, int objectId, Component modifier)
        {
            throw new NotImplementedException();
        }

        public override void DoRemove(Component c, int objectId, Component modifier)
        {
            throw new NotImplementedException();
        }
    }
}
