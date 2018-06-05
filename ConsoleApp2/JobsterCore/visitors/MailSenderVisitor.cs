using JobsterV2.models.components;
using JobsterV2.models.strategies;
using JobsterV2.models.visitors;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.visitors
{
    public class MailSenderVisitor : Visitor
    {
        public override void SetStrategy(Strategy aStrategy)
        {
            throw new NotImplementedException();
        }
    }
}
