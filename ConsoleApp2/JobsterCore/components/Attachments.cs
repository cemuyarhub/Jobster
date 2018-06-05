using JobsterV2.models.components;
using JobsterV2.models.enums;
using JobsterV2.models.visitors;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.components
{
    public class Attachments : CompositeComponent
    {
       
        public Attachments(int id) : base(Enums.ComponentNames.Attachments, id)
        {
        }

        public override void Visit(Visitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
