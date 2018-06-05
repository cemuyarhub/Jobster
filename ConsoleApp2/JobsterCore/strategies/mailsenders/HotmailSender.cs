using JobsterV2.models.components;
using JobsterV2.models.strategies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace ConsoleApp2.mailsenders
{
    public  class HotmailSender:Strategy
    {
 
        private readonly string name = "Microsoft";

        public override void Implement(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
