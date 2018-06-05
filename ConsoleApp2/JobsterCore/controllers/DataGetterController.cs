using ConsoleApp2.managers;
using ConsoleApp2.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.controllers
{
  public  class DataGetterController
    {
        private DataGetterManager dgManager = new DataGetterManager();

        public User GetAllData(string email)//GONNA BE CHANGED
        {
            User result = new User();

            foreach (var item in dgManager.GetGetterList())
            {
                result = item.ExtractData(result);
            }
            return result;
        }


    }
}
