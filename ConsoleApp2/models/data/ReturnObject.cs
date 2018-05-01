using Jobster.models.components;
using Jobster.models.enums;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobster.models.data
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
