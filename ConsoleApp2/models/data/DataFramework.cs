using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.models.data
{
   public abstract class DataFramework
    {

        public abstract ReturnObject Read(ReturnObject obj);
        public abstract ReturnObject Update(ReturnObject obj);

        public abstract ReturnObject Delete(ReturnObject obj);

        public abstract ReturnObject Insert(ReturnObject obj);


    }
}
