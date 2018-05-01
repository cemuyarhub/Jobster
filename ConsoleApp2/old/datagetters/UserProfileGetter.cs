using ConsoleApp2.models;
using ConsoleApp2.Models.DataGetters;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.data.datagetters
{
    public class UserProfileGetter:IGetter
    {
        public UserDatabaseOperator Db { get; set; }

        public User ExtractData(User user)
        {
            Db = new UserDatabaseOperator();
            user =Db.GetUser(user.Email);

            return user;

        }

        public string GetName()
        {
            return "UserProfileGetter";
        }




    }
}
