using Jobster.models.mailsenders;
using Jobster.components;
using Jobster.models.components.navigation;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;
using Jobster.models.data;
using Jobster.models.components.state;

namespace Jobster.models.components
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

        public abstract ReturnObject Send(MailSender mailSender);

        public abstract void Format(MailSender mailSender);

        public ReturnObject SendWithFormat(MailSender mailSender)
        {
            Format(mailSender);
            return Send(mailSender);
        }
    }
}
