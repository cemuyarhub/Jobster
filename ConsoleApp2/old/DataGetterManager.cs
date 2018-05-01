using ConsoleApp2.models.managers;
using ConsoleApp2.Models.DataGetters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.managers
{
  public  class  DataGetterManager: BaseManager
    {

        private  List<IGetter> getterList = new List<IGetter>();

        public void  DataGetterManager()
        {
            getterList.Add(new UserProfileGetter());//IT SHOULD BE on the top.
            getterList.Add(new MailTemplatesGetter());
            getterList.Add(new UserMailPreferencesGetter());
        }

        public List<IGetter> GetGetterList()
        {
            return getterList;
        }


    }
}
