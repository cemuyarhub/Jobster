using Jobster.models.components;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components
{
    public class TrashBox : CompositeComponent
    {
        public TrashBox(int objectId) : base(Enums.ComponentNames.TrashBox, objectId)
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
