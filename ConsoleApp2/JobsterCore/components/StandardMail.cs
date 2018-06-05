using JobsterV2.models.components;
using JobsterV2.models.enums;
using JobsterV2.models.visitors;
using System;

namespace JobsterV2.components
{
    public class StandardMail:Mail
    {
      
        public StandardMail(int objectId):base(Enums.ComponentNames.StandardMail, objectId)
        {
        }

    
        public override void Visit(Visitor visitor)
        {
            throw new NotImplementedException();
        }

        public int MailTemplateId { get; set; }
     }
}
