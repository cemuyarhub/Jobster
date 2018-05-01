using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.models.data
{
   public class Reader:BaseModel
    {

        public MySqlDataReader DataReader { get; set; }
    }
}
