using ConsoleApp2.models;
using ConsoleApp2.Models.DataGetters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.data.datagetters
{
    class UserMailPreferencesGetter:IGetter
    {
        public UserDatabaseOperator Db { get; set; }
        public User ExtractData(User user)
        {
            Db = new UserDatabaseOperator();

           user= user.UserSettings.AddRange(Db.GetUserMailPreferences(user.Id));

            return user;

        }



        public string GetName() { return "UserMailPreferencesGetter"; }





    }
}
