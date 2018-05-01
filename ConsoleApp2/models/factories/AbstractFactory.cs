using Jobster.models.components;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.models.factories
{
    public abstract class AbstractFactory
    {
        protected static AbstractFactory _instance;

        public abstract Component Create(Enums.ComponentNames name, int objectId); 
        


    }
}
