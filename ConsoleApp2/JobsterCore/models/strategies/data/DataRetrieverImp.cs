using JobsterV2.models.components;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.strategies.data
{
    public abstract class DataRetrieverImp:Strategy
    {
        public abstract void GetDataFromDb(Component component);

        public abstract void AddDataToComponentTree(Component component);

        public abstract Boolean CheckIfComponentExistsOnTree(Component component, CompositeComponent compositeComponent);

    }
}
