using Jobster.models.components;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components
{
    public class SentBox : CompositeComponent
    {
        public SentBox(int objectId) : base(Enums.ComponentNames.SentBox, objectId)
        {
        }

        public override void LoadFromDb()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
}
