using ConsoleApp2.models;
using ConsoleApp2.models.managers;
using ConsoleApp2.models.settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.managers
{
   public class SettingsManager:BaseManager
    {
        private List<BaseModel> settings = new List<BaseModel>();

        public override void PrepareData()
        {

            settings.Add(new UserMailPreferences());

        }

        public override List<BaseModel> GetList()
        {
            return settings;
        }



    }
}
