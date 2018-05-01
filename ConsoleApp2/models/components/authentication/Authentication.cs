using ConsoleApp2.models.authenticators.imp;
using ConsoleApp2.models.data;
using Google.Apis.Auth.OAuth2;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.models.components.authentication
{
  public abstract class Authentication:PrimitiveComponent
    {

        public int UserId { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Id { get; set; }
        public int Status { get; set; }

        public int TypeOfLoginId { get; set; }

        protected AuthenticationImplementor _authenticator;

        public Authentication(Enums.ComponentNames name, int objectId):base(name,objectId)
        {
        }

        public void SetAuthenticator(AuthenticationImplementor baseImp)
        {
            _authenticator = baseImp;
        }

        public abstract ReturnObject Authenticate();

        
        public abstract ReturnObject GetTypeOfLoginId();


    }
}
