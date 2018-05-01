using ConsoleApp2.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models.DataGetters
{
   public interface IGetter:BaseModel
    {
        User ExtractData(User user);

        string GetName();

        UserDatabaseOperator Db { get; set; }

    }
}
