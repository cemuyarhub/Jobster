using ConsoleApp2.models;
using ConsoleApp2.models.authentication;
using ConsoleApp2.models.data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.data.operators
{
   public static class AuthenticationOperator
    {


        public static ReturnObject GetAuthGoogle(string query) //TODO TO BE CHANGED
        {

            Authentication result = null;


            ReturnObject obj = DatabaseOperator.Read(query);
            Reader reader = (Reader)obj.Object;
            MySqlDataReader dataReader = reader.DataReader;



            while (dataReader.Read())
            {
                if((int)dataReader["type_of_login_id"] == 1)
                {

                    result = new Authentication()
                    {
                       Id = (int)dataReader["id"],
                        UserId = (int)dataReader["user_id"],
                        AccessToken = dataReader["access_token"].ToString(),
                        RefreshToken = dataReader["refresh_token"].ToString(),
                        CreateTime= (DateTime)dataReader["create_time"],
                        LastUpdateTime = (DateTime)dataReader["last_update_time"],
                        Status = (int)dataReader["status"],
                        TypeOfLoginId = (int)dataReader["user_id"]
                    };
                    break;

                }
            }

            dataReader.Close();
            obj.Object = result;

            return obj;
        }

        public static ReturnObject GetAuthById(int auth_id)
        {
            string query = "SELECT * FROM authentications WHERE id ='" + auth_id + "'";
            return GetAuthGoogle(query);
        }

        public static ReturnObject GetAuthByAuthCode(string auth_code, int typeOfLogin)
        {
            string query = "";
            if (typeOfLogin==1)
            query = "SELECT * FROM authentications WHERE refresh_token ='" + auth_code + "'";

            return GetAuthGoogle(query);
        }



        public static ReturnObject InsertNewAuthenticationGoogle(Authentication auth)
        {
            Authentication googleAuth = (Authentication)auth;

            string query = "INSERT INTO authentications (user_id,access_token,refresh_token,create_time,last_update_time,status,type_of_login_id) VALUES("
                + "'" + googleAuth.UserId + "',"
                + "'" + googleAuth.AccessToken + "',"
                + "'" + googleAuth.RefreshToken + "',"
                + "'" + googleAuth.CreateTime + "',"
                + "'" + googleAuth.LastUpdateTime + "',"
                + "'" + googleAuth.Status + "',"
                + "'" + googleAuth.TypeOfLoginId + "')";
            return DatabaseOperator.CreateOrUpdateOrDelete(query, Enums.OperationType.Create);



        }

        public static ReturnObject UpdateOrDeleteUser(Authentication auth, Enums.OperationType type)
        {
            Authentication googleAuth = (Authentication)auth;
            if (type == Enums.OperationType.Delete)
                googleAuth.Status = 0;

            string query = "UPDATE authentications SET "
                + "user_id='" + googleAuth.UserId + "',"
                + "access_token='" + googleAuth.AccessToken + "',"
                + "refresh_token='" + googleAuth.RefreshToken + "',"
                + "create_time='" + googleAuth.CreateTime + "',"
                + "last_update_time='" + googleAuth.LastUpdateTime + "',"
                + "status='" + googleAuth.Status + "',"
                + "type_of_login_id='" + googleAuth.TypeOfLoginId + "')";

            if (type == Enums.OperationType.Update)
                return DatabaseOperator.CreateOrUpdateOrDelete(query, Enums.OperationType.Update);
            else
                return DatabaseOperator.CreateOrUpdateOrDelete(query, Enums.OperationType.Delete);


        }



    }
}
