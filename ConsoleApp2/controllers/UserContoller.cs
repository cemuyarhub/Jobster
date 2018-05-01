using ConsoleApp2.authenticators;
using ConsoleApp2.data;
using ConsoleApp2.data.operators;
using ConsoleApp2.managers;
using ConsoleApp2.models;
using ConsoleApp2.models.authentication;
using ConsoleApp2.models.authenticators;
using ConsoleApp2.models.data;
using ConsoleApp2.models.settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.controllers
{
   public class UserController
    {


        public User User { get; set; }

        public ReturnObject AddNewUser(User newuser)
        {

           ReturnObject obj= UserOperator.GetUserByEmail(newuser.Email);

            if (ReturnObjectHelper.IsSucess(obj) && ReturnObjectHelper.IsObjectExist(obj))
            {
               obj= UserOperator.InsertNewUser(newuser);
                               
            }

            return obj;
        }

       public void LogOn(int typeOfLogin)
        {
          Authentication baseAuth= AuthenticationController.GetAuthenticationData(typeOfLogin);
            ReturnObject obj = AuthenticationOperator.GetAuthByAuthCode(baseAuth.RefreshToken, typeOfLogin);
            
            if(ReturnObjectHelper.IsSucess(obj) && ReturnObjectHelper.IsObjectExist(obj))
            {
                Authentication returnAuth =(Authentication) ReturnObjectHelper.ExtractObject(obj);


            } else if(ReturnObjectHelper.IsSucess(obj) && !ReturnObjectHelper.IsObjectExist(obj))
            {

            }
            else
            {


            }






        }



    }
}
