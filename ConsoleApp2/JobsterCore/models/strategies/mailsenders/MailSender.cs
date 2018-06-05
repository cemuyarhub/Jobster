using ConsoleApp2.models.data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1.Data;
using JobsterV2.models.components;
using JobsterV2.models.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.strategies.mailsenders
{
   public abstract class MailSender:Strategy
    {
     public abstract void DoSendMail(Mail mail);
     public abstract void DoFormatMail(Mail mail);
        
    }
}
