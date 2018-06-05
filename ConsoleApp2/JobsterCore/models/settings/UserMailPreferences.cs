using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.models.settings
{
   public class UserMailPreferences:ISettings
    {
        public string GetName() { return "UserMailPreferences"; }
        public int Id { get; set; }
        public int User_id { get; set; }


        public DateTime ChangeDate { get; set; }



    }
}
