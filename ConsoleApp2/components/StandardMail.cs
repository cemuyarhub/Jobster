using ConsoleApp2.models;
using Jobster.models.components;
using Jobster.models.data;
using Jobster.models.enums;
using Jobster.models.mailsenders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components
{
    public class StandardMail:Mail
    {
      


        public StandardMail(int objectId):base(Enums.ComponentNames.StandardMail, objectId)
        {
        }


        public override ReturnObject Send(MailSender mailSender)
        {

        return mailSender.DoSendMail((Mail)this);

        }

        public override void Save()
        {
            throw new NotImplementedException();
        }

        public override void LoadFromDb()
        {
            throw new NotImplementedException();
        }

        public override void Format(MailSender mailSender)
        {
            FormatedMail=mailSender.DoFormatMail((Mail)this);
        }

       

        public int MailTemplateId { get; set; }
    

      

    
    }
}
