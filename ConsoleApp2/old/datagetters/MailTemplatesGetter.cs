using ConsoleApp2.models;
using ConsoleApp2.Models.DataGetters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.data.datagetters
{
   public class MailTemplatesGetter:IGetter
    {

        public UserDatabaseOperator Db { get; set; }
        public User ExtractData(User user)
        {
            Db = new UserDatabaseOperator();

           user.Mailtemplates=  Db.GetMailTemplates(user.Id);

            return user;

        }



        public string GetName() { return "MailtemplateGetter"; }








    }
}
