using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.models.data
{
   public abstract class DatabaseOperatorFactory
    {

        public abstract DatabaseOperator CreateLatestConfig();
        

    }
}
