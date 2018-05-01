using ConsoleApp2.models;
using ConsoleApp2.models.data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.data.frameworks
{
    public class MySqlFramework:DataFramework
    {

        private MySqlConnection connection;

        private MySqlConnection CreateAndOpenConnection()
        {

            MySqlConnection connection = new MySqlConnection();
            String server = "127.0.0.1";
            String database = "jobsearch";
            String uid = "root";
            String password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;

        }
        private MySqlConnection CloseConnection(MySqlConnection connection)
        {
            connection.Close();
            return connection;

        }
        private ReturnObject CreateOrUpdateOrDelete(string queryString, Enums.OperationType type)
        {

            try
            {
                connection = CreateAndOpenConnection();

                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                cmd.ExecuteNonQuery();
                logger.LogHelper.Log(Enums.LogTarget.Database, "Success", Enums.ActionType.Db, "CreateOrUpdateOrDelete");
                connection = CloseConnection(connection);
                ReturnObject obj = new StandardReturnObject()
                {
                    Type = Enums.DataReturnType.Success,
                    Message = "Success"
                };
                return obj;
            }
            catch (Exception ex)
            {
                logger.LogHelper.Log(Enums.LogTarget.Database, ex.Message, Enums.ActionType.Db, "CreateOrUpdateOrDelete");

                connection = CloseConnection(connection);
                ReturnObject obj = new StandardReturnObject()
                {
                    Type = Enums.DataReturnType.Failure,
                    Message = ex.Message
                };
                return obj;

                // throw ex;
            }
        }

      
        public override ReturnObject Read(ReturnObject obj)
        {
            try
            {
                string queryString = obj.Message;
                connection = CreateAndOpenConnection();
                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                logger.LogHelper.Log(Enums.LogTarget.Database, "Success", Enums.ActionType.Db, "Read");
                connection = CloseConnection(connection);
                Reader tmp = new Reader() { DataReader = dataReader };
                ReturnObject returnObj = new StandardReturnObject()
                {
                    Type = Enums.DataReturnType.Success,
                    Message = "Success",
                    Object = tmp
                };
                return obj;

            }
            catch (Exception ex)
            {
                logger.LogHelper.Log(Enums.LogTarget.Database, ex.Message, Enums.ActionType.Db, "Read");
                connection = CloseConnection(connection);
                ReturnObject returnObj = new StandardReturnObject()
                {
                    Type = Enums.DataReturnType.Failure,
                    Message = ex.Message
                };
                return obj;

                //   throw ex;
            }
        }

        public override ReturnObject Update(ReturnObject obj)
        {
            string query = obj.Message;
            return CreateOrUpdateOrDelete(query, Enums.OperationType.Update);


        }

        public override ReturnObject Delete(ReturnObject obj)
        {
            string query = obj.Message;
            return CreateOrUpdateOrDelete(query, Enums.OperationType.Delete);


        }

        public override ReturnObject Insert(ReturnObject obj)
        {
            string query = obj.Message;
            return CreateOrUpdateOrDelete(query,Enums.OperationType.Create);

        }
    }
}
