using JobsterV2.models.components;
using JobsterV2.models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsterV2.models.data
{
   public abstract class ReturnObject
    {

        public string Message { get; set; }

        public Enums.DataReturnType Result { get; set; }        
        public Component Component { get; set; }

        public abstract Boolean IsSucess();

        public abstract Boolean IsObjectExist();

    }
}
