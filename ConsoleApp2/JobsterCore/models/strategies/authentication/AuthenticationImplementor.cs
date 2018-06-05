using ConsoleApp2.models.data;
using JobsterV2.models.components.authentication;
using JobsterV2.models.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.strategies.authentication
{
    public abstract class AuthenticationImplementor:Strategy
    {
    

        public abstract void Authenticate(Authentication modifier);

    }
}
