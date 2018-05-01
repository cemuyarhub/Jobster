using MySql.Data.MySqlClient;
using System;
using ConsoleApp2.models;
using ConsoleApp2.models.data;

namespace ConsoleApp2.data.operators
{
    public static class UserOperator
    {
      
    private static ReturnObject GetUser(string query ) 
        {


            User user = new User();

            ReturnObject obj = DatabaseOperator.Read(query);
            Reader reader = (Reader)obj.Object;
            MySqlDataReader dataReader = reader.DataReader;

            while (dataReader.Read())
            {
                user.Id = (int)dataReader["id"];
                user.Email = dataReader["email"].ToString();
                user.Lastname = dataReader["lastname"].ToString();
                user.Name = dataReader["name"].ToString();
                user.Status = (int)dataReader["status"];
                user.CreateTime= (DateTime)dataReader["create_time"];
                user.LastUpdateTime = (DateTime)dataReader["last_update_time"];
                user.TypeOfLoginId = (int)dataReader["type_of_login_id"];
                break;
            }
            obj.Object = user;
            dataReader.Close();
            return obj;
        }

        public static ReturnObject GetUserByEmail(string email)
        {
            string query = "SELECT * FROM User WHERE email='" + email + "'";
            return GetUser(query);
        }
        public static ReturnObject GetUserById(int userId)
        {
            string query = "SELECT * FROM User WHERE id='" + userId + "'";
            return GetUser(query);
        }

        public static ReturnObject InsertNewUser(User user)
        {
            string query = "INSERT INTO User (name,last_name,email,type_of_login_id,create_time,last_update_time,status) VALUES("
                + "'" + user.Name + "',"
                + "'" + user.Lastname + "',"
                + "'" + user.Email + "',"
                + "'" + user.TypeOfLoginId + "',"
                + "'" + user.CreateTime + "',"
                + "'" + user.LastUpdateTime + "',"
                + "'" + user.Status + "')";
            return DatabaseOperator.CreateOrUpdateOrDelete(query, Enums.OperationType.Create);



        }

        public static ReturnObject UpdateOrDeleteUser(User user, Enums.OperationType type)
        {
            if (type == Enums.OperationType.Delete)
                user.Status = 0;

            string query = "UPDATE User SET "
                + "name='" + user.Name + "',"
                + "last_name='" + user.Lastname + "',"
                + "email='" + user.Email + "',"
                + "type_of_login_id='" + user.TypeOfLoginId + "',"
                + "create_time='" + user.CreateTime + "',"
                + "last_update_time='" + user.LastUpdateTime + "',"
                + "status='" + user.Status + "')";

            if(type==Enums.OperationType.Update)
            return DatabaseOperator.CreateOrUpdateOrDelete(query, Enums.OperationType.Update);
            else
            return DatabaseOperator.CreateOrUpdateOrDelete(query, Enums.OperationType.Delete);


        }



    }
}
