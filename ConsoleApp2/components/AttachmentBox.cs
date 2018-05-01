using Jobster.models.components;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components
{
    public class Attachments : CompositeComponent
    {
       
        public Attachments(int id) : base(Enums.ComponentNames.AttachmentBox, id)
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
