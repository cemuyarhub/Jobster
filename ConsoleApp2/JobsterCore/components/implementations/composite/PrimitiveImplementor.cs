using ConsoleApp2.models;
using JobsterV2.models.components;
using JobsterV2.models.components.implementations;
using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components.implementors
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

        public override void DoMove(Component c, int fromCompositeObjectId, int targetCompositeObjectId, Component modifier)
        {
            throw new NotImplementedException();
        }

        public override void DoRemove(Component c, int objectId, Component modifier)
        {
            throw new NotImplementedException();
        }
    }
}
