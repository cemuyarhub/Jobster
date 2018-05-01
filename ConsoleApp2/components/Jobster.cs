using Jobster.models.components;
using Jobster.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.components
{
   public class Jobster:RootController
    {
        public Jobster(int objectId) : base(Enums.ComponentNames.Jobster, objectId)
        {

        }
    }
}
