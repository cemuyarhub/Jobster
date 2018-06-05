using JobsterV2.models.components;
using JobsterV2.models.enums;
using JobsterV2.models.visitors;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components
{
    public class DraftBox : CompositeComponent
    {
        public DraftBox(int objectId) : base(Enums.ComponentNames.DraftBox, objectId)
        {
        }

        public override void Visit(Visitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
