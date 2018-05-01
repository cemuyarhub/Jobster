using Jobster.models.components;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components
{
    public class UserProfile : Profile
    {
        public UserProfile(int objectId) : base(Enums.ComponentNames.UserProfile, objectId)
        {
        }


    }
}
