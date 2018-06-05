using JobsterV2.models.components.state;
using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.components
{
    public abstract class MailTemplate:CompositeComponent
    {

        public MailTemplate(Enums.ComponentNames name, int objectId):base(name, objectId)
        {

        }

        public string Body { get; set; }
        public string Subject { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public int Status { get; set; }
        public int UserId { get; set; }

        public DateTime CreateTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
      

    }
}
