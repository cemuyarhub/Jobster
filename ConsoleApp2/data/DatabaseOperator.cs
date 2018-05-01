using ConsoleApp2.models;
using ConsoleApp2.models.data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.data
{
    public abstract class  DatabaseOperator
    {
 


        public abstract ReturnObject GetSpesifiedData(Component c);
        public abstract ReturnObject InsertData(Component c);
        public abstract ReturnObject ModifyData(Component c);
        public abstract ReturnObject DeleteData(Component c);
   


    }
}
