using ConsoleApp2.models.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.models.authenticators.imp
{
    public abstract class AuthenticationImplementor
    {
        protected DataBase _data;

        

        public abstract ReturnObject Authenticate();

        public abstract ReturnObject GetLoginTypeId();
    }
}
