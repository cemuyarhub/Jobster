using ConsoleApp2.mailsenders;
using ConsoleApp2.models;
using ConsoleApp2.models.mailsenders;
using ConsoleApp2.models.managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.managers
{
   public  class MailSenderManager: BaseManager
    {
    private List<BaseModel> senderList = new List<BaseModel>();

    
        public override List<models.BaseModel> GetList()
        {
            return senderList;

        }



        public override void PrepareData()
        {

            senderList.Add(new GmailSender());
            senderList.Add(new HotmailSender());

        }
   
    }
}
