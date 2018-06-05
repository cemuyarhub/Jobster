using JobsterV2.components;
using JobsterV2.models.components.navigation;
using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;
using JobsterV2.models.data;
using JobsterV2.models.components.state;

namespace JobsterV2.models.components
{
   public abstract class Mail:CompositeComponent
    {

        public Mail(Enums.ComponentNames name, int id) : base(name, id)
        {
        }


        public string FormatedMail { get; set; }

        public string TargetMail { get; set; }

        public string FromMail { get; set; }

        public int Id { get; set; }

        public int UserId { get; set; }

        public int Status { get; set; }

        public DateTime SendDate { get; set; }

 
    }
}
