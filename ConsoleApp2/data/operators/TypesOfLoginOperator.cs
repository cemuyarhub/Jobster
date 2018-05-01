using ConsoleApp2.models;
using ConsoleApp2.models.data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.data.operators
{
    public static class TypesOfLoginOperator
    {
        public static ReturnObject GetIdFromType(string type)
        {
            string query = "SELECT * FROM types_of_login where type='" +type + "'" ;

            ReturnObject obj = DatabaseOperator.Read(query);
            Reader reader = (Reader)obj.Object;
            MySqlDataReader dataReader = reader.DataReader;
            TypesOfLogin target = new TypesOfLogin();

            while (dataReader.Read())
            {

                target.Id= (int)dataReader["id"];
                target.Type = dataReader["type"].ToString();

            }
            dataReader.Close();
            obj.Object = target;
            return obj;
        }



    }
}
