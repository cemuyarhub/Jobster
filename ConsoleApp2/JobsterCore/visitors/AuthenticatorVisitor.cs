using JobsterV2.models.strategies;
using JobsterV2.models.visitors;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.visitors
{
    class AuthenticatorVisitor : Visitor
    {
        public override void SetStrategy(Strategy aStrategy)
        {
            throw new NotImplementedException();
        }
    }
}
