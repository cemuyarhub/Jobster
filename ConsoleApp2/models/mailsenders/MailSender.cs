using ConsoleApp2.models.data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1.Data;
using Jobster.models.components;
using Jobster.models.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.models.mailsenders
{
   public abstract class MailSender
    {

       private string name;
      public abstract ReturnObject DoSendMail(Mail mail);

        public abstract string DoFormatMail(Mail mail);
        
    }
}
