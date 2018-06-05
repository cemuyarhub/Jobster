using JobsterV2.models.components;
using JobsterV2.models.strategies.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.strategies.data
{
    public class EntityFrameworkDataSavior : DataSaviorImp
    {
        protected EntityFrameworkDataSavior()
        {
        }

        public override void SaveDataToDb(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
