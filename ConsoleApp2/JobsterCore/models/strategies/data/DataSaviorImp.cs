using JobsterV2.models.components;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.strategies.data
{
   public abstract class DataSaviorImp
    {
        public abstract void SaveDataToDb(Component component);


    }
}
