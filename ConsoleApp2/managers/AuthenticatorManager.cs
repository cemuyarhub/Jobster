using ConsoleApp2.authenticators;
using ConsoleApp2.models;
using ConsoleApp2.models.authenticators;
using ConsoleApp2.models.managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.managers
{
  public   class AuthenticatorManager: BaseManager
    {
       private static List<BaseModel> authenticators = new List<BaseModel>();

      
        public override void PrepareData()
        {

            authenticators.Add(new GmailAuthenticator());


        }

        public override List<BaseModel> GetList()
        {
            return authenticators;
        }

    }
}
