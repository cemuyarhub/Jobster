using JobsterV2.models.components;
using JobsterV2.models.enums;
using JobsterV2.models.visitors;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components
{
    public class TrashBox : CompositeComponent
    {
        public TrashBox(int objectId) : base(Enums.ComponentNames.TrashBox, objectId)
        {
        }

        public override void Visit(Visitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
