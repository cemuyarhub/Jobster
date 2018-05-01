using ConsoleApp2.authenticators;
using ConsoleApp2.models.authentication;
using ConsoleApp2.models.authenticators;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.controllers
{
 public static class AuthenticationController
    {

        public static Authentication GetAuthenticationData(int typeOfLogin)
        {
            BaseAuthenticator authBase = null;
            Authentication authObj = null;


            switch (typeOfLogin)
            {
                case 1://google
                    authBase = (GmailAuthentication)new GmailAuthentication();
                    break;

                case 2:


                    break;


                default:
                    break;
            }

            authObj = authBase.Authenticate();
            return authObj;

        }

    }
}
