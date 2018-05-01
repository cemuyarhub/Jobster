using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.models.logger
{
    public abstract class BaseLogger
    {

        protected BaseLogger successor;

        public void SetSuccessor(BaseLogger successor)
        {
            this.successor = successor;
        }

        public abstract void Log(Log log);
    }
}