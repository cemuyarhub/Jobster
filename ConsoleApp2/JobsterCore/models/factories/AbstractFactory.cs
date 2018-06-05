using JobsterV2.models.components;
using JobsterV2.models.components.index;
using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.factories
{
    public abstract class AbstractFactory
    {
        protected static AbstractFactory _instance;

        protected IndexCounter _incrementor;

        public abstract Component Create(Enums.ComponentNames name);

        public abstract void SetIncrementor(IndexCounter incrementor);

    }
}
