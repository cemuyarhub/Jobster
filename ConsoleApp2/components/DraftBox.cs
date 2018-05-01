using Jobster.models.components;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components
{
    public class DraftBox : CompositeComponent
    {
        public DraftBox(int objectId) : base(Enums.ComponentNames.DraftBox, objectId)
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
