using Google.Apis.Auth.OAuth2;
using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.components.authentication
{
  public abstract class Authentication:PrimitiveComponent
    {

        public int UserId { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Id { get; set; }
        public int Status { get; set; }

        public int TypeOfLoginId { get; set; }

        public Authentication(Enums.ComponentNames name, int objectId):base(name,objectId)
        {
        }

    }
}
